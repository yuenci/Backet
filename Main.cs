using Backet.UI_Conponents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backet
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            AddCard();
            Tools.DetectDataFile();
        }

        private void SearchTextBox_Enter(object sender, EventArgs e)
        {
            string text = SearchTextBox.Text;
            if (text == "Search")
            {
                SearchTextBox.Text = "";
                SearchTextBox.ForeColor = Color.Black;
            }
        }

        private void SearchTextBox_Leave(object sender, EventArgs e)
        {
            string text = SearchTextBox.Text;
            if (text == "")
            {
                SearchTextBox.Text = "Search";
                SearchTextBox.ForeColor = Color.Silver;
            }
        }

        private void AddCard()
        {
            
            
            string[] repoNames = Tools.GetAllRepoNamFromLocal();
            int taskNumber = repoNames.Length;
            TaskNum.Text = taskNumber.ToString();
            SelectedTaskNum.Text = taskNumber.ToString();


            for (int i=0;i< taskNumber; i++)
            {
                TaskCard taskCard = new TaskCard();
                taskCard.InitCard(repoNames[i]);
                taskCard.Margin = new Padding(0, 0, 11, 0);
                CardContainer.Controls.Add(taskCard);
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Submit submitForm = new Submit();
            submitForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] data = Tools.GetDataFromRepoName("Java-Car-Rental-System");
            Console.WriteLine(data[10]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
    
        }
    }
}
