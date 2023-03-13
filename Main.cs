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
using System.Diagnostics;
using Backet.Forms;
using Sunny.UI;

namespace Backet
{
    public partial class Main : Form
    {
        public Dictionary<string, TaskCard> taskCardDict = new Dictionary<string, TaskCard>();
        public Dictionary<string, string> taskCardStatus = new Dictionary<string, string>();
        public static Main instance;
        int taskNumberCashe = 0;
        bool isTokenExist = false;
        public Main()
        {
            instance = this;
            InitializeComponent();
            Tools.DetectDataFile();
            Tools.DetectSettingsFile();
            isTokenExist = Tools.DetectTokenFile();
            InitStyle();
            InitToken();
            InitCards();
            InitSettings();
        }
        private void InitToken()
        {
            if (isTokenExist == true) return;
            DialogResult result = MessageBox.Show("Please obtain a GitHub token before using this app's features. You can generate a token by following the instructions on GitHub's website.\r\n", "Warning", MessageBoxButtons.OK);
            if (result == DialogResult.OK)
            {
                Process.Start("https://docs.github.com/en/github/authenticating-to-github/creating-a-personal-access-token");
                new Settings().ShowDialog();
            }

        }
        private void InitSettings()
        {
            string settingsFilePath = Tools.GetDataFilePath("settings.txt");
            string jsonData = File.ReadAllText(settingsFilePath);
            Others.Settings settings = Newtonsoft.Json.JsonConvert.DeserializeObject<Others.Settings>(jsonData);

            //Console.WriteLine(settings.Status);
            InitStatusCombobox(settings.Status);
            FilterCardsAccordToStatus();
        }
        private void InitStyle()
        {
            SearchBtn.FillColor = Color.Transparent;
            MenuBtn.FillColor = Color.Transparent;
            Settings.FillColor = Color.Transparent;

            SearchBtn.ForeColor = Color.FromArgb(64, 64, 64);
            MenuBtn.ForeColor = Color.FromArgb(64, 64, 64);
            Settings.ForeColor = Color.FromArgb(64, 64, 64);

            SearchTextBox.RectColor = Color.Transparent;

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
            if (isTokenExist != true) return;

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
                AddCardToContainer(repoNames[i]);
            }
        }

        public void AddCardToContainer(string repoNames)
        {
            TaskCard taskCard = new TaskCard();
            taskCard.InitCard(repoNames);
            taskCard.Margin = new Padding(0, 0, 11, 0);
            CardContainer.Controls.Add(taskCard);

            taskCardDict.Add(repoNames, taskCard);
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
            FilterCardsAccordToStatus();

            // Change Setting local cache;
            string selectedText = TypeComboBox.SelectedItem.ToString();
            ChangeSettingStatus(selectedText.ToLower());
            
        }

        private void FilterCardsAccordToStatus()
        {
            int selectedIndex = TypeComboBox.SelectedIndex;
            CardContainer.Controls.Clear();
            if (selectedIndex == 0)
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            taskCardStatus.Remove("Backet");
            CardContainer.Controls.Remove(taskCardDict["Backet"]);
            taskCardDict.Remove("Backet");
            AddCardToContainer("Backet");
            
        }

        private void TaskIcon_Click(object sender, EventArgs e)
        {
            InitCards();
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.ShowDialog();
        }

        private void InitStatusCombobox(string status)
        {
            if (status =="all")
            {
                TypeComboBox.SelectedIndex = 0;
            } 
            else if (status == "todo")
            {
                TypeComboBox.SelectedIndex = 1;
            }
            else if (status == "in progress")
            {
                TypeComboBox.SelectedIndex = 2;
            }
            else if (status == "done")
            {
                TypeComboBox.SelectedIndex = 3;
            }
        }

        private void ChangeSettingStatus(string status)
        {
            Others.Settings settings = new Others.Settings
            {
                Status = status
            };
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(settings);
            File.WriteAllText(Tools.GetDataFilePath("settings.txt"), json);
        }
    }
}
