namespace NoReinstallHub;

public sealed class InstructionsForm : Form
{
    private const string InstructionsText = @"NoReinstallHub - Instructions
---

🇺🇸 English: How to trick Windows

This program creates a fake link (Junction Point). Windows will think the files are in the ""Destination Folder"", but the actual space is used in the ""Source Folder"".

1. Step 1: Define the Source (Where real files live)

  • Select the folder containing the actual data (e.g., on your HDD). This is the physical location.

2. Step 2: Define the Destination (The trick)

  • Select the path where Windows or your games expect to find the files.

  • GOLDEN RULE: This folder MUST NOT exist yet. If it does, delete it. The program will create a smart link with that exact name.

3. Step 3: Execute the Trick

  • Click ""DO IT"". A ""ghost"" folder will appear, redirecting everything to the HDD.

---

🇪🇸 Español: Cómo engañar a Windows

Este programa crea un enlace falso (Junction Point). Windows creerá que los archivos están en la ""Carpeta Destino"", pero el espacio real se consumirá en la ""Carpeta Origen"".

1. Paso 1: Define el Origen (Donde están los archivos reales)

  • Selecciona la carpeta que contiene los datos reales (ej. en tu HDD). Esta es la ubicación física donde se guardará todo.

2. Paso 2: Define el Destino (El engaño)

  • Selecciona la ruta donde Windows o tus juegos esperan encontrar los archivos.

  • REGLA DE ORO: Esta carpeta NO debe existir todavía. Si existe, bórrala. El programa creará un acceso inteligente con ese nombre exacto.

3. Paso 3: Ejecuta el Engaño

  • Pulsa ""DO IT"". Aparecerá una carpeta ""fantasma"" que redirige todo al HDD.

---

🇺🇸 English: How to trick Windows

This program creates a fake link (Junction Point). Windows will think the files are in the ""Destination Folder"", but the actual space is used in the ""Source Folder"".

1. Step 1: Define the Source (Where real files live)

  • Select the folder containing the actual data (e.g., on your HDD). This is the physical location.

2. Step 2: Define the Destination (The trick)

  • Select the path where Windows or your games expect to find the files.

  • GOLDEN RULE: This folder MUST NOT exist yet. If it does, delete it. The program will create a smart link with that exact name.

3. Step 3: Execute the Trick

  • Click ""DO IT"". A ""ghost"" folder will appear, redirecting everything to the HDD.

---

🇧🇷 Português: Como enganar o Windows

Este programa cria um link falso (Junction Point). O Windows pensará que os arquivos estão na ""Pasta de Destino"", mas o espaço real será consumido na ""Pasta de Origem"".

1. Passo 1: Defina a Origem (Onde estão os arquivos reais)

  • Selecione a pasta que contém os dados reais (ex: no seu HDD). Esta é a localização física.

2. Passo 2: Defina o Destino (O engano)

  • Selecione o caminho onde o Windows ou seus jogos esperam encontrar os arquivos.

  • REGRA DE OURO: Esta pasta NÃO deve existir ainda. Se existir, apague-a.

3. Passo 3: Execute o Engano

  • Clique em ""DO IT"". Uma pasta ""fantasma"" aparecerá, redirecionando tudo para o HDD.

---

🇫🇷 Français: Comment tromper Windows

Ce programme crée un faux lien (Junction Point). Windows croira que les fichiers sont dans le ""Dossier de Destination"", mais l'espace réel sera consommé dans le ""Dossier Source"".

1. Étape 1 : Définir la Source (Où se trouvent les fichiers réels)

  • Sélectionnez le dossier contenant les données réelles (ex: sur votre HDD). C'est l'emplacement physique.

2. Étape 2 : Définir la Destination (La ruse)

  • Sélectionnez le chemin où Windows ou vos jeux s'attendent à trouver les fichiers.

  • RÈGLE D'OR : Ce dossier NE DOIT PAS encore exister. S'il existe, supprimez-le.

3. Étape 3 : Exécuter la Ruse

  • Cliquez sur ""DO IT"". Un dossier ""fantôme"" apparaîtra, redirigeant tout vers le HDD.

---

DISCLAIMER

Use at your own risk. The author is not responsible for any data loss due to improper folder deletion.";

    public InstructionsForm()
    {
        Text = "NoReinstallHub - Instructions";
        Size = new Size(580, 520);
        StartPosition = FormStartPosition.CenterParent;
        MinimizeBox = false;
        MaximizeBox = true;
        FormBorderStyle = FormBorderStyle.Sizable;
        MinimumSize = new Size(400, 300);
        BackColor = Color.FromArgb(30, 30, 30);
        Font = new Font("Segoe UI", 9F);

        var textBox = new TextBox
        {
            Multiline = true,
            ReadOnly = true,
            ScrollBars = ScrollBars.Vertical,
            Dock = DockStyle.Fill,
            Font = new Font("Segoe UI", 9.5f),
            BorderStyle = BorderStyle.None,
            BackColor = Color.FromArgb(30, 30, 30),
            ForeColor = Color.FromArgb(224, 224, 224),
            Margin = new Padding(12),
            Text = InstructionsText,
            WordWrap = true
        };

        var panel = new Panel { Dock = DockStyle.Fill, Padding = new Padding(12), BackColor = Color.FromArgb(30, 30, 30) };
        panel.Controls.Add(textBox);
        Controls.Add(panel);
    }
}
