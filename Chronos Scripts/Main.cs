using System;
using System.IO;
using System.Windows.Forms;

namespace Chronos_Scripts
{
    public partial class Main : Form
    {
        public Main()
        {
            AppDomain.CurrentDomain.UnhandledException += (s, e) => { Classes.LogHandler.LoggerCode(e.ExceptionObject.ToString()); };

            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void MiniBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void CopyBtn_Click(object sender, EventArgs e)
        {
            if (Scripts.SelectedIndex == -1) return;
            string Item = Scripts.SelectedItem.ToString();
            Clipboard.SetText(File.ReadAllText("./scripts/" + Item));
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Scripts.Items.Clear();
            foreach (var Txt in new DirectoryInfo("scripts\\").GetFiles("*.txt"))
                Scripts.Items.Add(Txt.Name);

            foreach (var Lua in new DirectoryInfo("scripts\\").GetFiles("*.lua"))
                Scripts.Items.Add(Lua.Name);
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            Scripts.SelectedIndex = Scripts.FindString(Search.Text);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Owner - Payton
Remaster - Nam3", "Chronos Scripts - Credits", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
