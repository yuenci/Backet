using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backet
{
    public partial class Submit : Form
    {
        private string RopeURLCache = "";
        private string FigmaURLCache = ""; 
        private string LocalPathCache = "";
        public Submit()
        {
            InitializeComponent();
        }

        public void InitForm(string repoURL, string figmarURL, string localPath)
        {
            this.RepoURL.Text = repoURL;
            RopeURLCache = repoURL;
            this.RepoURL.Enabled = false;

            this.FigmaURL.Text = figmarURL;
            this.FigmaURLCache = figmarURL;

            this.LocalPath.Text = localPath;
            this.LocalPathCache = localPath;
        }

        private async void SubmitBtn_Click(object sender, EventArgs e)
        {
            string repoURL = RepoURL.Text;
            string figma = FigmaURL.Text;
            string file = LocalPath.Text;

            // if under modifier happen
            if (this.FigmaURLCache != "" || this.LocalPathCache != "")
            {
                // if any modify
                if (this.FigmaURL.Text != this.FigmaURLCache || this.LocalPath.Text != this.LocalPathCache)
                {
                    UpdateInfo();
                    return;
                }
                this.Close();
            }


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
            repoInfo += $",\"figma_url\":\"{figmaRRL}\",";
            repoInfo += $"\"local_path\":\"{path.Replace("\\", "//")}\",";
            repoInfo += $"\"complete\":false";
            repoInfo += "}";
            //Console.WriteLine(repoInfo);
            return repoInfo;
        }

        private void  UpdateInfo()
        {
            string ropeName = Tools.getRepoNameFromURL(this.RopeURLCache);
            string data = Tools.GetDataFromRepoName(ropeName,"string");
            //Console.WriteLine(data);


            if (this.FigmaURL.Text != this.FigmaURLCache)
            {
                data = data.Replace(this.FigmaURLCache, this.FigmaURL.Text);
            }

            if (this.LocalPath.Text != this.LocalPathCache)
            {
                data = data.Replace(this.LocalPathCache, this.LocalPath.Text);
            }

            Tools.SaveDataToRepoFile(ropeName,data);
            this.Close();
        }
    }
}
