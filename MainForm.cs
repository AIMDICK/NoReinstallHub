using System.Diagnostics;
using System.IO;
using System.Security.Principal;

namespace NoReinstallHub;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
        SetFormIcon();
        CheckAdminPrivileges();
        Log("Application started.");
    }

    private static bool IsRunningAsAdministrator()
    {
        try
        {
            var identity = WindowsIdentity.GetCurrent();
            var principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }
        catch
        {
            return false;
        }
    }

    private void CheckAdminPrivileges()
    {
        if (!IsRunningAsAdministrator())
        {
            panelAdminWarning.Visible = true;
            Log("WARNING: Not running as Administrator. Junction creation may fail.");
        }
    }

    private void BtnRestartAdmin_Click(object? sender, EventArgs e)
    {
        try
        {
            var startInfo = new ProcessStartInfo
            {
                FileName = Application.ExecutablePath,
                UseShellExecute = true,
                Verb = "runas"
            };
            Process.Start(startInfo);
            Application.Exit();
        }
        catch (Exception ex)
        {
            Log($"Failed to restart as Admin: {ex.Message}");
            MessageBox.Show("Could not restart as Administrator. Please run the program as Admin manually.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void Log(string message)
    {
        var timestamp = DateTime.Now.ToString("HH:mm");
        var line = $"[{timestamp}] {message}\r\n";
        txtLog.AppendText(line);
        txtLog.SelectionStart = txtLog.Text.Length;
        txtLog.ScrollToCaret();
    }

    private void SetFormIcon()
    {
        try
        {
            var icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            if (icon != null)
                Icon = icon;
        }
        catch { /* ignore if icon cannot be loaded */ }
    }

    private void BtnOrigen_Click(object? sender, EventArgs e)
    {
        using var dlg = new FolderBrowserDialog
        {
            Description = "Select the folder where the actual files are (source)",
            UseDescriptionForTitle = true
        };
        if (dlg.ShowDialog() == DialogResult.OK)
        {
            txtOrigen.Text = dlg.SelectedPath;
            Log("Source folder selected.");
        }
    }

    private void BtnDestino_Click(object? sender, EventArgs e)
    {
        using var dlg = new FolderBrowserDialog
        {
            Description = "Select the folder path that will be the junction (destination link)",
            UseDescriptionForTitle = true
        };
        if (dlg.ShowDialog() == DialogResult.OK)
        {
            txtDestino.Text = dlg.SelectedPath;
            Log("Destination folder selected.");
        }
    }

    private void BtnHowToUse_Click(object? sender, EventArgs e)
    {
        using var instructions = new InstructionsForm();
        instructions.ShowDialog(this);
    }

    private void BtnCrearJunction_Click(object? sender, EventArgs e)
    {
        var origen = txtOrigen.Text.Trim();
        var destino = txtDestino.Text.Trim();

        if (string.IsNullOrEmpty(origen))
        {
            MessageBox.Show("Please select the source folder.", "Source Folder", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (string.IsNullOrEmpty(destino))
        {
            MessageBox.Show("Please select the destination folder (link path).", "Destination Folder", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        Log("Source validated.");
        if (!Directory.Exists(origen))
        {
            Log("Error: Source folder does not exist.");
            MessageBox.Show("The source folder does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        // Seguridad: destino NO debe existir o debe estar vacía (mklink exige que el enlace no exista)
        if (Directory.Exists(destino))
        {
            try
            {
                var entries = Directory.EnumerateFileSystemEntries(destino);
                if (entries.Any())
                {
                    Log("Error: Destination folder exists and is not empty.");
                    MessageBox.Show(
                        "The destination folder already exists and is not empty. It must be empty or not exist to create the junction.",
                        "Invalid Destination",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
                Directory.Delete(destino);
            }
            catch (Exception ex)
            {
                Log($"Error: Could not check or clear destination: {ex.Message}");
                MessageBox.Show($"Could not check or clear the destination folder: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        Log("Destination validated.");
        // Create parent directory of destination if it doesn't exist (mklink doesn't create it)
        var parentDest = Path.GetDirectoryName(destino);
        if (!string.IsNullOrEmpty(parentDest) && !Directory.Exists(parentDest))
        {
            try
            {
                Directory.CreateDirectory(parentDest);
            }
            catch (Exception ex)
            {
                Log($"Error: Could not create parent folder: {ex.Message}");
                MessageBox.Show($"Could not create the destination parent folder: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        Log("Creating junction...");
        try
        {
            var startInfo = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = $"/c mklink /J \"{destino}\" \"{origen}\"",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true
            };

            using var process = Process.Start(startInfo);
            if (process == null)
            {
                Log("Error: Could not start mklink process.");
                MessageBox.Show("Could not start the process to create the junction.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var salida = process.StandardOutput.ReadToEnd();
            var errores = process.StandardError.ReadToEnd();
            process.WaitForExit(5000);

            if (process.ExitCode == 0)
            {
                Log("Success.");
                MessageBox.Show($"Junction created successfully.\n\nLink: {destino}\nPoints to: {origen}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var mensaje = string.IsNullOrWhiteSpace(errores) ? salida : errores;
                Log($"Error: Junction creation failed (code {process.ExitCode}).");
                MessageBox.Show($"Error creating the junction (code {process.ExitCode}):\n{mensaje}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        catch (Exception ex)
        {
            Log($"Error: {ex.Message}");
            MessageBox.Show($"Error running mklink: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
