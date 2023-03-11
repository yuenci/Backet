using Backet.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backet.UI_Conponents
{
    public partial class TaskCard : UserControl
    {
        public string[] cardInfo;
        public string repoName;
        public TaskCard()
        {
            InitializeComponent();
            
        }
        public void InitCard(string repoName)
        {
            this.repoName = repoName;
            this.cardInfo = Tools.GetRepoCardInfo(repoName);
            InitBackground();
            InitLabels();
            InitIcons();
            Main.instance.AddNameAndStatusToMap(repoName, cardInfo[6]);
        }
        private void InitBackground()
        {
            if (this.cardInfo[1] =="true")
            {
                mainPanel.FillColor = Color.FromArgb(233, 236, 239);
            }
        }
        private void InitLabels()
        {
            TaskName.Text = this.repoName;
            StartDate.Text = this.cardInfo[2];
            UpdateDate.Text = this.cardInfo[3];
        }
        private void InitIcons()
        {
            AddIcons("github");
            if (cardInfo[4] !="")
            {
                AddIcons("figma");
            }

            if (cardInfo[5] != "")
            {
                AddIcons("file");
            }
            
            
        }

        private void AddIcons(string iconName)
        {
            Image image = null;
            if (iconName == "github")
            {
                image = Properties.Resources.githubIcon;
            }
            else if (iconName == "figma")
            {
                image = Properties.Resources.figmaIcon;
            }
            else if (iconName == "file")
            {
                image = Properties.Resources.fileIcon;
            }


            PictureBox pictureBox = new PictureBox
            {
                Image = image,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Size = new Size(30, 30)
            };
            
            pictureBox.Cursor = Cursors.Hand;

            if (iconName == "github")
            {
                pictureBox.Click += new EventHandler(Github_icon_Click);
            }
            else if (iconName == "figma")
            {
                pictureBox.Click += new EventHandler(Figma_icon_Click);
            }
            else if (iconName == "file")
            {
                pictureBox.Click += new EventHandler(File_icon_Click);
            }

            IconsPanel.Controls.Add(pictureBox);
        }

        private void TaskName_Click(object sender, EventArgs e)
        {
            Details details = new Details();
            details.InitTaskCard(this);
            details.ShowDialog();
        }


        private void Github_icon_Click(object sender, EventArgs e)
        {
            string url = $"https://github.com/{cardInfo[0]}"; 
            Process.Start(url); 
        }

        private void Figma_icon_Click(object sender, EventArgs e)
        {
            string url = cardInfo[4];
            Process.Start(url);
        }

        private void File_icon_Click(object sender, EventArgs e)
        {
            string filePath = cardInfo[5].Replace("//", "\\");
            Console.WriteLine(filePath);
            Process.Start("explorer.exe", $"/select,\"{filePath}\"");
        }
    }
}
