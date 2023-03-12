namespace Backet
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.uiPanel7 = new Sunny.UI.UIPanel();
            this.Settings = new Sunny.UI.UIAvatar();
            this.AddBtn = new Sunny.UI.UIAvatar();
            this.uiPanel8 = new Sunny.UI.UIPanel();
            this.SearchTextBox = new Sunny.UI.UITextBox();
            this.SearchBtn = new Sunny.UI.UIAvatar();
            this.MenuBtn = new Sunny.UI.UIAvatar();
            this.TaskIcon = new Sunny.UI.UILabel();
            this.TaskNum = new Sunny.UI.UIAvatar();
            this.TypeComboBox = new Sunny.UI.UIComboBox();
            this.SelectedTaskNum = new Sunny.UI.UIAvatar();
            this.CardContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.uiPanel7.SuspendLayout();
            this.uiPanel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiPanel7
            // 
            this.uiPanel7.Controls.Add(this.Settings);
            this.uiPanel7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.uiPanel7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel7.Location = new System.Drawing.Point(14, 15);
            this.uiPanel7.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.uiPanel7.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel7.Name = "uiPanel7";
            this.uiPanel7.Radius = 10;
            this.uiPanel7.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(232)))), ((int)(((byte)(231)))));
            this.uiPanel7.Size = new System.Drawing.Size(50, 50);
            this.uiPanel7.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel7.TabIndex = 2;
            this.uiPanel7.Text = null;
            this.uiPanel7.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Settings
            // 
            this.Settings.AvatarSize = 55;
            this.Settings.BackColor = System.Drawing.Color.Transparent;
            this.Settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Settings.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Settings.Location = new System.Drawing.Point(3, 5);
            this.Settings.MinimumSize = new System.Drawing.Size(1, 1);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(40, 40);
            this.Settings.Style = Sunny.UI.UIStyle.Custom;
            this.Settings.Symbol = 103;
            this.Settings.SymbolSize = 35;
            this.Settings.TabIndex = 9;
            this.Settings.Text = "uiAvatar2";
            // 
            // AddBtn
            // 
            this.AddBtn.AvatarSize = 48;
            this.AddBtn.BackColor = System.Drawing.Color.Transparent;
            this.AddBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddBtn.FillColor = System.Drawing.Color.Black;
            this.AddBtn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.Location = new System.Drawing.Point(972, 15);
            this.AddBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(50, 50);
            this.AddBtn.Style = Sunny.UI.UIStyle.Custom;
            this.AddBtn.Symbol = 76;
            this.AddBtn.SymbolSize = 35;
            this.AddBtn.TabIndex = 6;
            this.AddBtn.Text = "uiAvatar1";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // uiPanel8
            // 
            this.uiPanel8.Controls.Add(this.SearchTextBox);
            this.uiPanel8.Controls.Add(this.SearchBtn);
            this.uiPanel8.Controls.Add(this.MenuBtn);
            this.uiPanel8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.uiPanel8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel8.Location = new System.Drawing.Point(74, 15);
            this.uiPanel8.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.uiPanel8.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel8.Name = "uiPanel8";
            this.uiPanel8.Radius = 10;
            this.uiPanel8.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(232)))), ((int)(((byte)(231)))));
            this.uiPanel8.Size = new System.Drawing.Size(890, 50);
            this.uiPanel8.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel8.TabIndex = 3;
            this.uiPanel8.Text = null;
            this.uiPanel8.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTextBox.Location = new System.Drawing.Point(50, 10);
            this.SearchTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchTextBox.MinimumSize = new System.Drawing.Size(1, 16);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.ShowText = false;
            this.SearchTextBox.Size = new System.Drawing.Size(739, 29);
            this.SearchTextBox.Style = Sunny.UI.UIStyle.Custom;
            this.SearchTextBox.TabIndex = 7;
            this.SearchTextBox.Text = "Search";
            this.SearchTextBox.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.SearchTextBox.Watermark = "";
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            this.SearchTextBox.Leave += new System.EventHandler(this.SearchTextBox_Leave);
            this.SearchTextBox.Enter += new System.EventHandler(this.SearchTextBox_Enter);
            // 
            // SearchBtn
            // 
            this.SearchBtn.AvatarSize = 55;
            this.SearchBtn.BackColor = System.Drawing.Color.Transparent;
            this.SearchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchBtn.FillColor = System.Drawing.Color.Transparent;
            this.SearchBtn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SearchBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SearchBtn.Location = new System.Drawing.Point(840, 3);
            this.SearchBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(40, 40);
            this.SearchBtn.Style = Sunny.UI.UIStyle.Custom;
            this.SearchBtn.Symbol = 85;
            this.SearchBtn.SymbolSize = 25;
            this.SearchBtn.TabIndex = 8;
            this.SearchBtn.Text = "uiAvatar1";
            // 
            // MenuBtn
            // 
            this.MenuBtn.AvatarSize = 55;
            this.MenuBtn.BackColor = System.Drawing.Color.Transparent;
            this.MenuBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuBtn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MenuBtn.Location = new System.Drawing.Point(3, 7);
            this.MenuBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.MenuBtn.Name = "MenuBtn";
            this.MenuBtn.Size = new System.Drawing.Size(40, 40);
            this.MenuBtn.Style = Sunny.UI.UIStyle.Custom;
            this.MenuBtn.Symbol = 97;
            this.MenuBtn.SymbolSize = 40;
            this.MenuBtn.TabIndex = 7;
            this.MenuBtn.Text = "uiAvatar2";
            // 
            // TaskIcon
            // 
            this.TaskIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TaskIcon.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskIcon.Location = new System.Drawing.Point(72, 90);
            this.TaskIcon.Name = "TaskIcon";
            this.TaskIcon.Size = new System.Drawing.Size(68, 36);
            this.TaskIcon.TabIndex = 7;
            this.TaskIcon.Text = "Tasks";
            this.TaskIcon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TaskIcon.Click += new System.EventHandler(this.TaskIcon_Click);
            // 
            // TaskNum
            // 
            this.TaskNum.AvatarSize = 20;
            this.TaskNum.BackColor = System.Drawing.Color.Transparent;
            this.TaskNum.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.TaskNum.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskNum.ForeColor = System.Drawing.Color.White;
            this.TaskNum.Icon = Sunny.UI.UIAvatar.UIIcon.Text;
            this.TaskNum.Location = new System.Drawing.Point(137, 97);
            this.TaskNum.MinimumSize = new System.Drawing.Size(1, 1);
            this.TaskNum.Name = "TaskNum";
            this.TaskNum.Size = new System.Drawing.Size(25, 25);
            this.TaskNum.Style = Sunny.UI.UIStyle.Custom;
            this.TaskNum.Symbol = 61543;
            this.TaskNum.TabIndex = 8;
            this.TaskNum.Text = "6";
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.DataSource = null;
            this.TypeComboBox.FillColor = System.Drawing.Color.White;
            this.TypeComboBox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TypeComboBox.Items.AddRange(new object[] {
            "All",
            "Todo",
            "In Progress",
            "Done"});
            this.TypeComboBox.Location = new System.Drawing.Point(181, 97);
            this.TypeComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TypeComboBox.MinimumSize = new System.Drawing.Size(63, 0);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.TypeComboBox.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(232)))), ((int)(((byte)(231)))));
            this.TypeComboBox.RectSize = 2;
            this.TypeComboBox.Size = new System.Drawing.Size(132, 29);
            this.TypeComboBox.Style = Sunny.UI.UIStyle.Custom;
            this.TypeComboBox.TabIndex = 9;
            this.TypeComboBox.Text = "Status";
            this.TypeComboBox.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.TypeComboBox.Watermark = "";
            this.TypeComboBox.SelectedIndexChanged += new System.EventHandler(this.TypeComboBox_SelectedIndexChanged);
            // 
            // SelectedTaskNum
            // 
            this.SelectedTaskNum.AvatarSize = 20;
            this.SelectedTaskNum.BackColor = System.Drawing.Color.Transparent;
            this.SelectedTaskNum.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.SelectedTaskNum.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedTaskNum.ForeColor = System.Drawing.Color.DimGray;
            this.SelectedTaskNum.Icon = Sunny.UI.UIAvatar.UIIcon.Text;
            this.SelectedTaskNum.Location = new System.Drawing.Point(322, 98);
            this.SelectedTaskNum.MinimumSize = new System.Drawing.Size(1, 1);
            this.SelectedTaskNum.Name = "SelectedTaskNum";
            this.SelectedTaskNum.Size = new System.Drawing.Size(25, 25);
            this.SelectedTaskNum.Style = Sunny.UI.UIStyle.Custom;
            this.SelectedTaskNum.Symbol = 61543;
            this.SelectedTaskNum.TabIndex = 10;
            this.SelectedTaskNum.Text = "6";
            // 
            // CardContainer
            // 
            this.CardContainer.AutoScroll = true;
            this.CardContainer.Location = new System.Drawing.Point(74, 134);
            this.CardContainer.Name = "CardContainer";
            this.CardContainer.Size = new System.Drawing.Size(929, 515);
            this.CardContainer.TabIndex = 11;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1034, 661);
            this.Controls.Add(this.CardContainer);
            this.Controls.Add(this.SelectedTaskNum);
            this.Controls.Add(this.TypeComboBox);
            this.Controls.Add(this.TaskNum);
            this.Controls.Add(this.TaskIcon);
            this.Controls.Add(this.uiPanel8);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.uiPanel7);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backet";
            this.uiPanel7.ResumeLayout(false);
            this.uiPanel8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UIPanel uiPanel7;
        private Sunny.UI.UIAvatar AddBtn;
        private Sunny.UI.UIPanel uiPanel8;
        private Sunny.UI.UIAvatar SearchBtn;
        private Sunny.UI.UIAvatar MenuBtn;
        private Sunny.UI.UITextBox SearchTextBox;
        private Sunny.UI.UIAvatar Settings;
        private Sunny.UI.UILabel TaskIcon;
        private Sunny.UI.UIAvatar TaskNum;
        private Sunny.UI.UIComboBox TypeComboBox;
        private Sunny.UI.UIAvatar SelectedTaskNum;
        public System.Windows.Forms.FlowLayoutPanel CardContainer;
    }
}

