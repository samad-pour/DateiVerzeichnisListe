namespace DateiVerzeichnisListe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            if (Directory.Exists(@"C:\Temp"))
                Directory.SetCurrentDirectory(@"C:\Temp");
            else
                MessageBox.Show(@"Verzeichnis C:\Temp existiert nicht");
            lblAktuellesVerzeichnis.Text = Directory.GetCurrentDirectory();
        }

        private void btnDateiliste_Click(object sender, EventArgs e)
        {
            string verzeichnis;
            string[] dateiliste;

            verzeichnis = Directory.GetCurrentDirectory();
            dateiliste = Directory.GetFiles(verzeichnis);
            lstDisplay.Items.Clear();
            foreach (string s in dateiliste)
                lstDisplay.Items.Add(s);
        }

        private void btnSystemeintraege_Click(object sender, EventArgs e)
        {
            Systemeintraege();
        }

        private void Systemeintraege()
        {
            string verzeichnis;
            string[] dateiliste;

            verzeichnis = Directory.GetCurrentDirectory();
            dateiliste = Directory.GetFileSystemEntries(verzeichnis);
            lstDisplay.Items.Clear();
            foreach (string s in dateiliste)
                lstDisplay.Items.Add(s);
        }

        private void lstDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name;

            if (lstDisplay.SelectedIndex != -1)
            {
                name = lstDisplay.Text;
                lblDisplay.Text = name + "\nErzeugt: " +
                File.GetCreationTime(name) + "\nLetzter Zugriff: " +
                File.GetLastAccessTime(name) + "\n" + "Letzter " +
                "Schreibzugriff:" + File.GetLastWriteTime(name);
            }
            else
                MessageBox.Show("Kein Eintrag ausgewählt");
        }

        private void btnInVerzeichnis_Click(object sender, EventArgs e)
        {
            if (lstDisplay.SelectedIndex != -1)
            {
                try
                {
                    Directory.SetCurrentDirectory(lstDisplay.Text);
                }
                catch
                {
                    MessageBox.Show(lstDisplay.Text
                    + " ist kein Verzeichnis");
                }
            }
            else
                MessageBox.Show("Kein Eintrag ausgewählt");
            lblAktuellesVerzeichnis.Text = Directory.GetCurrentDirectory();
            Systemeintraege();
        }

        private void btnNachOben_Click(object sender, EventArgs e)
        {
            Directory.SetCurrentDirectory("..");
            lblAktuellesVerzeichnis.Text = Directory.GetCurrentDirectory();
            Systemeintraege();
        }
    }
}