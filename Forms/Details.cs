using Backet.UI_Conponents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backet.Forms
{
    public partial class Details : Form
    {
        private TaskCard taskCard = null;
        public Details()
        {
            InitializeComponent();
        }

        private void MoreOptBtn_Click(object sender, EventArgs e)
        {
            Submit submit = new Submit();
        }

        public void InitTaskCard(TaskCard taskCard)
        {
            this.taskCard = taskCard;
            InitLable();
        }

        private void InitLable() {
            repoName.Text = this.taskCard.repoName;
            if(this.taskCard.cardInfo[1] == "false")
            {
                statusLabel.Text = "Active";
            }
            else
            {
                statusLabel.Text = "Complete";
            }
            
            string[] detailsInfo = Tools.GetRepoDetailsInfo(this.taskCard.repoName);
            descriptionLable.Text = detailsInfo[0];
            homepageLabel.Text = detailsInfo[1];
            starLabel.Text = detailsInfo[2];
            languageLabel.Text = detailsInfo[3];
            issueLabel.Text = detailsInfo[4];
        }
    }
}
