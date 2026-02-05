namespace NoReinstallHub;

partial class MainForm
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
            components.Dispose();
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        btnOrigen = new Button();
        btnDestino = new Button();
        btnCrearJunction = new Button();
        btnHowToUse = new Button();
        txtOrigen = new TextBox();
        txtDestino = new TextBox();
        lblOrigen = new Label();
        lblDestino = new Label();
        txtLog = new TextBox();
        panelAdminWarning = new Panel();
        lblAdminWarning = new Label();
        btnRestartAdmin = new Button();
        panelAdminWarning.SuspendLayout();
        SuspendLayout();
        //
        // panelAdminWarning
        //
        panelAdminWarning.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        panelAdminWarning.BackColor = Color.FromArgb(74, 44, 42);
        panelAdminWarning.Controls.Add(lblAdminWarning);
        panelAdminWarning.Controls.Add(btnRestartAdmin);
        panelAdminWarning.Location = new Point(0, 0);
        panelAdminWarning.Name = "panelAdminWarning";
        panelAdminWarning.Size = new Size(684, 36);
        panelAdminWarning.TabIndex = 9;
        panelAdminWarning.Visible = false;
        //
        // lblAdminWarning
        //
        lblAdminWarning.AutoSize = true;
        lblAdminWarning.ForeColor = Color.FromArgb(255, 200, 200);
        lblAdminWarning.Location = new Point(12, 10);
        lblAdminWarning.Name = "lblAdminWarning";
        lblAdminWarning.Size = new Size(320, 15);
        lblAdminWarning.TabIndex = 0;
        lblAdminWarning.Text = "Not running as Administrator. Junction creation may fail.";
        //
        // btnRestartAdmin
        //
        btnRestartAdmin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnRestartAdmin.BackColor = Color.FromArgb(60, 60, 60);
        btnRestartAdmin.FlatAppearance.BorderColor = Color.FromArgb(85, 85, 85);
        btnRestartAdmin.FlatAppearance.BorderSize = 1;
        btnRestartAdmin.FlatStyle = FlatStyle.Flat;
        btnRestartAdmin.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnRestartAdmin.ForeColor = Color.White;
        btnRestartAdmin.Location = new Point(532, 5);
        btnRestartAdmin.Name = "btnRestartAdmin";
        btnRestartAdmin.Size = new Size(140, 26);
        btnRestartAdmin.TabIndex = 1;
        btnRestartAdmin.Text = "Restart as Admin";
        btnRestartAdmin.UseVisualStyleBackColor = false;
        btnRestartAdmin.Click += BtnRestartAdmin_Click;
        //
        // lblOrigen
        //
        lblOrigen.AutoSize = true;
        lblOrigen.BackColor = Color.Transparent;
        lblOrigen.Font = new Font("Segoe UI", 9F);
        lblOrigen.ForeColor = Color.FromArgb(224, 224, 224);
        lblOrigen.Location = new Point(24, 44);
        lblOrigen.Name = "lblOrigen";
        lblOrigen.Size = new Size(98, 15);
        lblOrigen.TabIndex = 0;
        lblOrigen.Text = "Source Folder:";
        //
        // txtOrigen
        //
        txtOrigen.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtOrigen.BackColor = Color.FromArgb(45, 45, 45);
        txtOrigen.BorderStyle = BorderStyle.FixedSingle;
        txtOrigen.Font = new Font("Segoe UI", 9F);
        txtOrigen.ForeColor = Color.FromArgb(224, 224, 224);
        txtOrigen.Location = new Point(24, 62);
        txtOrigen.Name = "txtOrigen";
        txtOrigen.PlaceholderText = "Path where the actual files are stored...";
        txtOrigen.ReadOnly = true;
        txtOrigen.Size = new Size(432, 23);
        txtOrigen.TabIndex = 2;
        //
        // btnOrigen
        //
        btnOrigen.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnOrigen.BackColor = Color.FromArgb(60, 60, 60);
        btnOrigen.FlatAppearance.BorderColor = Color.FromArgb(85, 85, 85);
        btnOrigen.FlatAppearance.BorderSize = 1;
        btnOrigen.FlatStyle = FlatStyle.Flat;
        btnOrigen.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnOrigen.ForeColor = Color.FromArgb(224, 224, 224);
        btnOrigen.Location = new Point(462, 60);
        btnOrigen.Name = "btnOrigen";
        btnOrigen.Size = new Size(200, 28);
        btnOrigen.TabIndex = 3;
        btnOrigen.Text = "Select Source Folder";
        btnOrigen.UseVisualStyleBackColor = false;
        btnOrigen.Click += BtnOrigen_Click;
        //
        // lblDestino
        //
        lblDestino.AutoSize = true;
        lblDestino.BackColor = Color.Transparent;
        lblDestino.Font = new Font("Segoe UI", 9F);
        lblDestino.ForeColor = Color.FromArgb(224, 224, 224);
        lblDestino.Location = new Point(24, 98);
        lblDestino.Name = "lblDestino";
        lblDestino.Size = new Size(95, 15);
        lblDestino.TabIndex = 4;
        lblDestino.Text = "Destination Folder:";
        //
        // txtDestino
        //
        txtDestino.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtDestino.BackColor = Color.FromArgb(45, 45, 45);
        txtDestino.BorderStyle = BorderStyle.FixedSingle;
        txtDestino.Font = new Font("Segoe UI", 9F);
        txtDestino.ForeColor = Color.FromArgb(224, 224, 224);
        txtDestino.Location = new Point(24, 116);
        txtDestino.Name = "txtDestino";
        txtDestino.PlaceholderText = "Path for the junction (link)...";
        txtDestino.ReadOnly = true;
        txtDestino.Size = new Size(432, 23);
        txtDestino.TabIndex = 5;
        //
        // btnDestino
        //
        btnDestino.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnDestino.BackColor = Color.FromArgb(60, 60, 60);
        btnDestino.FlatAppearance.BorderColor = Color.FromArgb(85, 85, 85);
        btnDestino.FlatAppearance.BorderSize = 1;
        btnDestino.FlatStyle = FlatStyle.Flat;
        btnDestino.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnDestino.ForeColor = Color.FromArgb(224, 224, 224);
        btnDestino.Location = new Point(462, 114);
        btnDestino.Name = "btnDestino";
        btnDestino.Size = new Size(200, 28);
        btnDestino.TabIndex = 6;
        btnDestino.Text = "Select Destination";
        btnDestino.UseVisualStyleBackColor = false;
        btnDestino.Click += BtnDestino_Click;
        //
        // btnCrearJunction
        //
        btnCrearJunction.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        btnCrearJunction.BackColor = Color.FromArgb(57, 255, 20);
        btnCrearJunction.FlatAppearance.BorderSize = 0;
        btnCrearJunction.FlatStyle = FlatStyle.Flat;
        btnCrearJunction.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnCrearJunction.ForeColor = Color.Black;
        btnCrearJunction.Location = new Point(24, 160);
        btnCrearJunction.Name = "btnCrearJunction";
        btnCrearJunction.Size = new Size(638, 40);
        btnCrearJunction.TabIndex = 7;
        btnCrearJunction.Text = "DO IT";
        btnCrearJunction.UseVisualStyleBackColor = false;
        btnCrearJunction.Click += BtnCrearJunction_Click;
        //
        // btnHowToUse
        //
        btnHowToUse.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btnHowToUse.BackColor = Color.FromArgb(60, 60, 60);
        btnHowToUse.FlatAppearance.BorderColor = Color.FromArgb(85, 85, 85);
        btnHowToUse.FlatAppearance.BorderSize = 1;
        btnHowToUse.FlatStyle = FlatStyle.Flat;
        btnHowToUse.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnHowToUse.ForeColor = Color.FromArgb(224, 224, 224);
        btnHowToUse.Location = new Point(542, 210);
        btnHowToUse.Name = "btnHowToUse";
        btnHowToUse.Size = new Size(120, 28);
        btnHowToUse.TabIndex = 8;
        btnHowToUse.Text = "How to use";
        btnHowToUse.UseVisualStyleBackColor = false;
        btnHowToUse.Click += BtnHowToUse_Click;
        //
        // txtLog
        //
        txtLog.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        txtLog.BackColor = Color.FromArgb(37, 37, 38);
        txtLog.BorderStyle = BorderStyle.FixedSingle;
        txtLog.Font = new Font("Segoe UI", 8.25F);
        txtLog.ForeColor = Color.FromArgb(212, 212, 212);
        txtLog.Location = new Point(24, 248);
        txtLog.Multiline = true;
        txtLog.Name = "txtLog";
        txtLog.ReadOnly = true;
        txtLog.ScrollBars = ScrollBars.Vertical;
        txtLog.Size = new Size(636, 72);
        txtLog.TabIndex = 10;
        txtLog.WordWrap = false;
        //
        // MainForm
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(30, 30, 30);
        ClientSize = new Size(684, 336);
        Controls.Add(txtLog);
        Controls.Add(panelAdminWarning);
        Controls.Add(btnHowToUse);
        Controls.Add(btnCrearJunction);
        Controls.Add(btnDestino);
        Controls.Add(txtDestino);
        Controls.Add(lblDestino);
        Controls.Add(btnOrigen);
        Controls.Add(txtOrigen);
        Controls.Add(lblOrigen);
        Font = new Font("Segoe UI", 9F);
        MinimumSize = new Size(700, 375);
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "NoReinstallHub";
        panelAdminWarning.ResumeLayout(false);
        panelAdminWarning.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblOrigen;
    private TextBox txtOrigen;
    private Button btnOrigen;
    private Label lblDestino;
    private TextBox txtDestino;
    private Button btnDestino;
    private Button btnCrearJunction;
    private Button btnHowToUse;
    private TextBox txtLog;
    private Panel panelAdminWarning;
    private Label lblAdminWarning;
    private Button btnRestartAdmin;
}
