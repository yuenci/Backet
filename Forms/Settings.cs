using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backet.Forms
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            AddLabels();
        }

        private void AddLabels()
        {
            string dataFolderPath = Path.Combine(Tools.GetRunningPath(), "data");
            DataFoldTextBox.Text = dataFolderPath;
            DataFoldTextBox.Enabled = false;

            TokenTextBox.Text = Token.token;
        }

        private void OpenDataBtn_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", DataFoldTextBox.Text);
        }

        private void TokenBtn_Click(object sender, EventArgs e)
        {
            string token = TokenTextBox.Text;
            if (token.Length != 0)
            {
                string path = Tools.GetDataFilePath("token.txt");
                File.WriteAllText(path, token);
            }
            this.Close();
        }
    }
}
