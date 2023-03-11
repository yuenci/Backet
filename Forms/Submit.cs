using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backet
{
    public partial class Submit : Form
    {
        public Submit()
        {
            InitializeComponent();
        }

        private async void SubmitBtn_Click(object sender, EventArgs e)
        {
            string repoURL = RepoURL.Text;
            string figma = FigmaURL.Text;
            string file = LocalPath.Text;


            if (repoURL == "" || !Tools.IsValidUrl(repoURL))
            {
                MessageBox.Show("Please Enter Valid Repositorie URL");
                return;
            }
            string repoName = Tools.getRepoNameFromURL(repoURL);
            string repoInfo = await Tools.GetRepoInfo(repoURL, Token.token);
            repoInfo = addFigmaURLAndPathToInfo(repoInfo, figma, file);
            Tools.WriteRepoJson(repoName, Tools.FormatJson(repoInfo));
            this.Close();
        }

        private string addFigmaURLAndPathToInfo(string repoInfo,string figmaRRL, string path)
        {
            repoInfo = repoInfo.Remove(repoInfo.Length - 1);
            repoInfo += $",\"figma_url\":\"{figmaRRL}\",\"local_path\":\"{path.Replace("\\", "//")}\"";
            repoInfo += "}";
            //Console.WriteLine(repoInfo);
            return repoInfo;
        }
    }
}
