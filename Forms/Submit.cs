using ExCSS;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Backet
{
    public partial class Submit : Form
    {
        private string RopeURLCache = "";
        private string FigmaURLCache = ""; 
        private string LocalPathCache = "";
        private string CompleteStatusCache = "";
        private bool IsFromDetailsPage = false;
        public Submit()
        {
            InitializeComponent();
        }

        public void InitForm(string repoURL, string figmarURL, string localPath,string complete)
        {
            this.RepoURL.Text = repoURL;
            RopeURLCache = repoURL;
            this.RepoURL.Enabled = false;

            this.FigmaURL.Text = figmarURL;
            this.FigmaURLCache = figmarURL;

            this.LocalPath.Text = localPath;
            this.LocalPathCache = localPath;

            ShowCompleteValueToText(complete);
            this.CompleteStatusCache = complete;

            IsFromDetailsPage = true;
        }

        private async void SubmitBtn_Click(object sender, EventArgs e)
        {
            string repoURL = RepoURL.Text;
            string figma = FigmaURL.Text;
            string file = LocalPath.Text;
            string taskStatus = "";

            // if under modifier happen
            if (this.FigmaURLCache != "" || this.LocalPathCache != "")
            {
                // if any modify
                if (this.FigmaURL.Text != this.FigmaURLCache  || this.LocalPath.Text != this.LocalPathCache )
                {
                    Console.WriteLine("yes11!!!");
                    UpdateInfo();
                    this.Close();
                    return;
                }
                else
                {
                    UpdateVisibility();
                    this.Close();
                    return;
                }
            }



            // checking input
            if (repoURL == "" || !Tools.IsValidUrl(repoURL))
            {
                MessageBox.Show("Please Enter Valid Repositorie URL");
                return;
            }

            int selectedIndex = TaskStatusComboBox.SelectedIndex;
            if (selectedIndex == -1)
            {
                MessageBox.Show("Please Selete Task Status");
                return;
            }
            else
            {
                taskStatus=  TaskStatusComboBox.SelectedItem.ToString();
            }





            string repoName = Tools.getRepoNameFromURL(repoURL);
            string repoInfo = await Tools.GetRepoInfo(repoURL, Token.token);
            repoInfo = addFigmaURLAndPathToInfo(repoInfo, figma, file, taskStatus);
            Tools.WriteRepoJson(repoName, Tools.FormatJson(repoInfo));
            Main.instance.InitCards();
            this.Close();

        }

        

        private string addFigmaURLAndPathToInfo(string repoInfo,string figmaRRL, string path,string taskStatus)
        {
            repoInfo = repoInfo.Remove(repoInfo.Length - 1);
            repoInfo += $",\"figma_url\":\"{figmaRRL}\",";
            repoInfo += $"\"local_path\":\"{path.Replace("\\", "//")}\",";
            repoInfo += GetCompleteStatusStr(taskStatus);
            repoInfo += "}";
            //Console.WriteLine(repoInfo);
            return repoInfo;
        }
        


        private string GetCompleteStatusStr(string taskStatus)
        {
            if (taskStatus == "Todo")
            {
                return "\"complete\":null";
            }
            else if (taskStatus == "Done")
            {
                return "\"complete\":true";
            }
            else
            {
                return "\"complete\":false";
            }

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

            if (this.TaskStatusComboBox.Text != this.CompleteStatusCache)
            {
                ReplaceCompleteStatus(this.TaskStatusComboBox.Text,this.CompleteStatusCache);
            }

            Tools.SaveDataToRepoFile(ropeName,data);
            ReloadCard(ropeName);
            this.Close();
        }

        private void ReloadCard(string repoName)
        {
            Main.instance.taskCardStatus.Remove(repoName);
            Main.instance.CardContainer.Controls.Remove(Main.instance.taskCardDict[repoName]);
            Main.instance.taskCardDict.Remove(repoName);
            Main.instance.AddCardToContainer(repoName);
        }

        private void ReplaceCompleteStatus(string oldVal,string newVal)
        {
            //todo
        }


        private void ShowCompleteValueToText(string completeVal)
        {
            if (completeVal == "null")
            {
                //TaskStatusComboBox.Text = "Active";
                TaskStatusComboBox.SelectedIndex = 0;

            }
            else if (completeVal == "false")
            {
                //TaskStatusComboBox.Text = "Todo";
                TaskStatusComboBox.SelectedIndex = 1;
            }
            else
            {
                //TaskStatusComboBox.Text = "Complete";
                TaskStatusComboBox.SelectedIndex = 2;
            }


            TaskStatusComboBox.Enabled = false;
        }

        private async void UpdateVisibility()
        {
            string repoURL = RepoURL.Text;
            string repoName = Tools.getRepoNameFromURL(repoURL);
            string repoInfoGithub = await Tools.GetRepoInfo(repoURL, Token.token);

            string repoDataLocal = Tools.GetDataFromRepoName(repoName, "string");


            Regex regex = new Regex("\"visibility\"\\s*:\\s*\"(private|public)\"");

            MatchCollection matches1 = regex.Matches(repoInfoGithub);
            string visibilityGithub = matches1[0].Groups[1].Value;

            MatchCollection matches2 = regex.Matches(repoDataLocal);
            string visibilityLocal = matches2[0].Groups[1].Value;

            if (visibilityGithub == visibilityLocal) return;

            //Console.WriteLine(visibilityGithub + "--" + visibilityLocal);

            string newRes;
            newRes = repoDataLocal.Replace("\"visibility\": \"private\"", $"\"visibility\": \"{visibilityGithub}\"");
            newRes = newRes.Replace("\"visibility\": \"public\"", $"\"visibility\": \"{visibilityGithub}\"");

            Tools.SaveDataToRepoFile(repoName, newRes);

            Main.instance.InitCards();
        }

    }
}
