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
using System.IO;

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
            InitProcessBar();
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
            StartDate.Text = "Start: " + Tools.ISO8601ToDDMMYY(this.cardInfo[2]);
            UpdateDate.Text ="Last updated" +  Tools.ISO8601ToDDMMYY(this.cardInfo[3]);
        }
        private void InitIcons()
        {
            AddIcons("github");
            if (cardInfo[4] !="")
            {
                AddIcons("figma");
            }

            if (IfTodoMdExist())
            {
                AddIcons("todo");
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
            else if (iconName == "todo")
            {
                image = Properties.Resources.todoIcon;
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
            else if (iconName == "todo")
            {
                pictureBox.Click += new EventHandler(Todo_icon_Click);
            }

            IconsPanel.Controls.Add(pictureBox);
        }


        private void InitProcessBar()
        {
            

            if (cardInfo[6].Contains("true"))
            {
                ProcessBar.Value = 100;
                return;
            }

            
            if (!IfTodoMdExist())
            {
                ProcessBar.Value = 0;
                return;
            }
            
            string todoPath = GetLocalPath() + "\\TODO.md";
            string[] data = File.ReadAllLines(todoPath);
            int allTodos = data.Length;
            int done = 0;
            foreach(string line in data)
            {
                if (line.Contains("- [x]"))
                {
                    done++;
                }
            }
            int result = (int)(((double)done / allTodos) * 100);
            ProcessBar.Value = result;
        }

        private bool IfTodoMdExist()
        {
            string todoPath = GetLocalPath() + "\\TODO.md";
            return Tools.IsPathExist(todoPath);
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
            string filePath = GetLocalPath();
            //Console.WriteLine(filePath);
            Process.Start("explorer.exe", $"/select,\"{filePath}\"");
        }

        private void Todo_icon_Click(object sender, EventArgs e)
        {
            string filePath = GetLocalPath() + "\\TODO.md";
            //Process.Start("explorer.exe", $"/select,\"{filePath}\"");
            Process.Start(filePath);
        }

        private string GetLocalPath()
        {
            return cardInfo[5].Replace("//", "\\");
        }
    }
}
