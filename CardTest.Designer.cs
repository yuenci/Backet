namespace Backet
{
    partial class CardTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.taskCard1 = new Backet.UI_Conponents.TaskCard();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.TaskName = new Sunny.UI.UILabel();
            this.IconsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiAvatar1 = new Sunny.UI.UIAvatar();
            this.uiSymbolButton1 = new Sunny.UI.UISymbolButton();
            this.uiPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // taskCard1
            // 
            this.taskCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.taskCard1.Location = new System.Drawing.Point(29, 80);
            this.taskCard1.Name = "taskCard1";
            this.taskCard1.Size = new System.Drawing.Size(290, 240);
            this.taskCard1.TabIndex = 0;
            this.taskCard1.Load += new System.EventHandler(this.taskCard1_Load);
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.uiSymbolButton1);
            this.uiPanel1.Controls.Add(this.uiLabel2);
            this.uiPanel1.Controls.Add(this.uiAvatar1);
            this.uiPanel1.Controls.Add(this.TaskName);
            this.uiPanel1.Controls.Add(this.IconsPanel);
            this.uiPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.uiPanel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel1.Location = new System.Drawing.Point(395, 90);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Radius = 10;
            this.uiPanel1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(232)))), ((int)(((byte)(231)))));
            this.uiPanel1.RectSize = 2;
            this.uiPanel1.Size = new System.Drawing.Size(280, 230);
            this.uiPanel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel1.TabIndex = 3;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TaskName
            // 
            this.TaskName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskName.Location = new System.Drawing.Point(12, 67);
            this.TaskName.Name = "TaskName";
            this.TaskName.Size = new System.Drawing.Size(253, 45);
            this.TaskName.Style = Sunny.UI.UIStyle.Custom;
            this.TaskName.TabIndex = 1;
            this.TaskName.Text = "uiLabel1uiLabel1uiLabel1uiLabel1uiLabel1";
            this.TaskName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // IconsPanel
            // 
            this.IconsPanel.Location = new System.Drawing.Point(16, 13);
            this.IconsPanel.Name = "IconsPanel";
            this.IconsPanel.Size = new System.Drawing.Size(180, 35);
            this.IconsPanel.TabIndex = 0;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel2.Location = new System.Drawing.Point(48, 138);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(201, 23);
            this.uiLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel2.TabIndex = 8;
            this.uiLabel2.Text = "End: Nov 12";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiAvatar1
            // 
            this.uiAvatar1.AvatarSize = 25;
            this.uiAvatar1.BackColor = System.Drawing.Color.Transparent;
            this.uiAvatar1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiAvatar1.Location = new System.Drawing.Point(12, 136);
            this.uiAvatar1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiAvatar1.Name = "uiAvatar1";
            this.uiAvatar1.Size = new System.Drawing.Size(30, 30);
            this.uiAvatar1.Style = Sunny.UI.UIStyle.Custom;
            this.uiAvatar1.Symbol = 57589;
            this.uiAvatar1.SymbolSize = 25;
            this.uiAvatar1.TabIndex = 7;
            this.uiAvatar1.Text = "uiAvatar1";
            // 
            // uiSymbolButton1
            // 
            this.uiSymbolButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(243)))), ((int)(((byte)(213)))));
            this.uiSymbolButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(153)))), ((int)(((byte)(56)))));
            this.uiSymbolButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uiSymbolButton1.Location = new System.Drawing.Point(16, 185);
            this.uiSymbolButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton1.Name = "uiSymbolButton1";
            this.uiSymbolButton1.Radius = 10;
            this.uiSymbolButton1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(243)))), ((int)(((byte)(213)))));
            this.uiSymbolButton1.Size = new System.Drawing.Size(131, 25);
            this.uiSymbolButton1.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolButton1.Symbol = 78;
            this.uiSymbolButton1.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(153)))), ((int)(((byte)(56)))));
            this.uiSymbolButton1.TabIndex = 4;
            this.uiSymbolButton1.Text = "Completed";
            this.uiSymbolButton1.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // CardTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uiPanel1);
            this.Controls.Add(this.taskCard1);
            this.Name = "CardTest";
            this.Text = "CardTest";
            this.uiPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UI_Conponents.TaskCard taskCard1;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UISymbolButton uiSymbolButton1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIAvatar uiAvatar1;
        private Sunny.UI.UILabel TaskName;
        private System.Windows.Forms.FlowLayoutPanel IconsPanel;
    }
}