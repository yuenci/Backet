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
            InitLabels();
            InitIcons();
            InitProcessBar();
            Main.instance.AddNameAndStatusToMap(repoName, cardInfo[6]);
            InitStyle();
        }
        private void InitStyle()
        {
            DateTimeIcon.ForeColor = Color.FromArgb(64, 64, 64);
            DateTimeIcon.FillColor = Color.Transparent;
            ProcessBar.RectColor = Color.FromArgb(1, 153, 56);
            InitBackground();
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

            if (cardInfo[6].Contains("true")) 
            {
                StartDate.Hide();
                DateTimeIcon.Hide();
                UpdateDate.Hide();
                AddFinishedInfoArea();
            }

            if (cardInfo[6].Contains("false"))
            {
                StartDate.Text = "Start:" + Tools.ISO8601ToDDMMYY(this.cardInfo[2]);
            }
            else if(cardInfo[6].Contains("null"))
            {
                StartDate.Text = "Todo:" + Tools.ISO8601ToDDMMYY(this.cardInfo[2]);
                DateTimeIcon.Symbol = 73;
            }

            UpdateDate.Text ="Last updated: " +  Tools.ISO8601ToDDMMYY(this.cardInfo[3]);
        }
        private void AddFinishedInfoArea()
        {
            FinishedInfoArea finishedInfoArea = new FinishedInfoArea();
            finishedInfoArea.Location = new Point(1, 115);
            finishedInfoArea.InitDate(this.cardInfo[7], this.cardInfo[3]);
            mainPanel.Controls.Add(finishedInfoArea);
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
                //ProcessBar.Value = 100;
                ProcessBar.Hide();
                return;
            }

            
            if (!IfTodoMdExist())
            {
                ProcessBar.Value = 0;
                ProcessBar.Cursor = Cursors.Hand;
                ProcessBar.Click += new EventHandler(CreateTODOAndOpenIt);
                return;
            }
            
            string todoPath = GetLocalPath() + "\\TODO.md";
            string[] data = File.ReadAllLines(todoPath);
            int allTodos = data.Length;
            int done = 0;
            foreach(string line in data)
            {
                if (line.Contains("- [x]") || line.Contains("* [X]"))
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

        private void CreateTODOAndOpenIt(object sender, EventArgs e)
        {
            string filePath = GetLocalPath() + "\\TODO.md";
            //Process.Start(filePath);  //error: busy or locked

            using (var fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.ReadWrite))
            {
                // 使用文件流写入数据
                using (var writer = new StreamWriter(fileStream))
                {
                    writer.WriteLine("- [ ] ");
                }
            }

            // 启动进程
            Process.Start(filePath);
            Main.instance.InitCards();
        }
    }
}
