using Backet.UI_Conponents;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backet.Forms
{
    public partial class Details : Form
    {
        private TaskCard taskCard = null;
        private string[] detailsInfo;
        public Details()
        {
            InitializeComponent();
        }

        private void MoreOptBtn_Click(object sender, EventArgs e)
        {
            Submit submit = new Submit();

            string figmaURL = this.taskCard.cardInfo[4];
            string pathLocal = this.taskCard.cardInfo[5];
            submit.InitForm(GetRepoUrl(), figmaURL, pathLocal);

            submit.ShowDialog();

        }

        public void InitTaskCard(TaskCard taskCard)
        {
            this.taskCard = taskCard;
            InitLable();
            InitLableEvent();
        }

        private void InitLable() {
            repoName.Text = this.taskCard.repoName;
            if(this.taskCard.cardInfo[6] == "false")
            {
                statusLabel.Text = "Active";

            }
            else if(this.taskCard.cardInfo[6] == "null")
            {
                statusLabel.Text = "Todo";
            }
            else
            {
                complereBtn.Enabled = false;
                statusLabel.Text = "Complete";
            }
            
            this.detailsInfo = Tools.GetRepoDetailsInfo(this.taskCard.repoName);
            descriptionLable.Text = this.detailsInfo[0];
            homepageLabel.Text = this.detailsInfo[1];
            starLabel.Text = this.detailsInfo[2];
            languageLabel.Text = this.detailsInfo[3];
            issueLabel.Text = this.detailsInfo[4];
        }

        private void InitLableEvent()
        {
            repoName.Click += new EventHandler(Reponame_Click);
            
            issueLabel.Click += new EventHandler(Issue_Click);
            issueTextLabel.Click += new EventHandler(Issue_Click);


            if (homepageLabel.Text != "")
            {
                homepageLabel.Click += new EventHandler(Homepage_Click);
                homepageTextLabel.Click += new EventHandler(Homepage_Click);
            }

        }

        private void Reponame_Click(object sender, EventArgs e)
        {
            string url = GetRepoUrl();
            Process.Start(url);
        }

        private void Issue_Click(object sender, EventArgs e)
        {
            string url = GetRepoUrl() + "/issues";
            Process.Start(url);
        }

        private void Homepage_Click(object sender, EventArgs e)
        {
            string url = this.detailsInfo[1];
            Process.Start(url);
        }

        private string GetRepoUrl()
        {
            return "https://github.com/" +  this.taskCard.cardInfo[0];
        }

        private void complereBtn_Click(object sender, EventArgs e)
        {
            string repoName = this.taskCard.repoName;
            string[] data = Tools.GetDataFromRepoName(repoName);
            List<string> list = new List<string>(data);
            string dataTime = Tools.GetNowISO8601();
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i].Contains("complete"))
                {
                    list[i] = data[i].Replace("false", "true,");
                    list[i] = data[i].Replace("null", "true,");
                    list.Insert(i + 1, $"  \"completeDate\": \"{dataTime}\"");
                }
            }
            string[] newData = list.ToArray();
            Tools.SaveDataToRepoFile(repoName, newData);
        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            string url = GetRepoUrl() + "/settings";
            Process.Start(url);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Tools.DeleteRepoFile(this.taskCard.repoName);
        }
    }
}
