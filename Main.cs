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
        private Dictionary<string, TaskCard> taskCardDict = new Dictionary<string, TaskCard>();
        public Dictionary<string, string> taskCardStatus = new Dictionary<string, string>();
        public static Main instance;
        int taskNumberCashe = 0;
        public Main()
        {
            instance = this;
            InitializeComponent();
            Tools.DetectDataFile();
            InitCards();
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

        public void InitCards()
        {
            taskCardDict.Clear();
            taskCardStatus.Clear();
            CardContainer.Controls.Clear();

            string[] repoNames = Tools.GetAllRepoNamFromLocal();
            int taskNumber = repoNames.Length;
            taskNumberCashe = taskNumber;
            TaskNum.Text = taskNumber.ToString();
            SelectedTaskNum.Text = taskNumber.ToString();


            for (int i=0;i< taskNumber; i++)
            {
                TaskCard taskCard = new TaskCard();
                taskCard.InitCard(repoNames[i]);
                taskCard.Margin = new Padding(0, 0, 11, 0);
                CardContainer.Controls.Add(taskCard);

                taskCardDict.Add(repoNames[i], taskCard);
            }
        }

        public void AddNameAndStatusToMap(string repoName, string status)
        {
            this.taskCardStatus.Add(repoName, status);
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
        

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            CardContainer.Controls.Clear();

            string textInput = SearchTextBox.Text.ToLower();
            int num = 0;


            ICollection<string> keys = taskCardDict.Keys;
            foreach (string key in keys)
            {
                if (key.ToLower().Contains(textInput))
                {
                    CardContainer.Controls.Add(taskCardDict[key]);
                    num++;
                }
            }
            SelectedTaskNum.Text = num.ToString();
        }

        private void TypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = TypeComboBox.SelectedIndex;
            CardContainer.Controls.Clear();
            if (selectedIndex ==0)
            {
                SelectedTaskNum.Text = taskNumberCashe.ToString();
                ICollection<TaskCard> cards = taskCardDict.Values;
                foreach (TaskCard card in cards)
                {
                    CardContainer.Controls.Add(card);
                }
            }
            else if (selectedIndex == 1)
            {
                AddStatusCardToPanel("null");
            }
            else if (selectedIndex == 2)
            {
                AddStatusCardToPanel("false");
            }
            else if (selectedIndex == 3)
            {
                AddStatusCardToPanel("true");
            }
        }

        private void AddStatusCardToPanel(string type)
        {
            int num = 0;
            foreach (KeyValuePair<string, string> kvp in taskCardStatus)
            {
                if (kvp.Value == type)
                {
                    TaskCard taskCard = taskCardDict[kvp.Key];
                    CardContainer.Controls.Add(taskCard);
                    num++;
                }

            }
            SelectedTaskNum.Text = num.ToString();
        }
    }
}
