namespace Backet.Forms
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.TokenTextBox = new Sunny.UI.UITextBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.DataFoldTextBox = new Sunny.UI.UITextBox();
            this.TokenBtn = new Sunny.UI.UIButton();
            this.OpenDataBtn = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.uiLabel1.Location = new System.Drawing.Point(12, 24);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(66, 23);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "Token";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TokenTextBox
            // 
            this.TokenTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TokenTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TokenTextBox.Location = new System.Drawing.Point(17, 52);
            this.TokenTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TokenTextBox.MinimumSize = new System.Drawing.Size(1, 16);
            this.TokenTextBox.Name = "TokenTextBox";
            this.TokenTextBox.ShowText = false;
            this.TokenTextBox.Size = new System.Drawing.Size(390, 30);
            this.TokenTextBox.TabIndex = 1;
            this.TokenTextBox.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.TokenTextBox.Watermark = "";
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.uiLabel2.Location = new System.Drawing.Point(12, 114);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(110, 23);
            this.uiLabel2.TabIndex = 2;
            this.uiLabel2.Text = "Data Folder";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DataFoldTextBox
            // 
            this.DataFoldTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DataFoldTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataFoldTextBox.Location = new System.Drawing.Point(17, 152);
            this.DataFoldTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DataFoldTextBox.MinimumSize = new System.Drawing.Size(1, 16);
            this.DataFoldTextBox.Name = "DataFoldTextBox";
            this.DataFoldTextBox.ShowText = false;
            this.DataFoldTextBox.Size = new System.Drawing.Size(390, 30);
            this.DataFoldTextBox.TabIndex = 3;
            this.DataFoldTextBox.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.DataFoldTextBox.Watermark = "";
            // 
            // TokenBtn
            // 
            this.TokenBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TokenBtn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TokenBtn.Location = new System.Drawing.Point(419, 52);
            this.TokenBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.TokenBtn.Name = "TokenBtn";
            this.TokenBtn.Size = new System.Drawing.Size(53, 30);
            this.TokenBtn.TabIndex = 4;
            this.TokenBtn.Text = "OK";
            this.TokenBtn.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TokenBtn.Click += new System.EventHandler(this.TokenBtn_Click);
            // 
            // OpenDataBtn
            // 
            this.OpenDataBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenDataBtn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OpenDataBtn.Location = new System.Drawing.Point(419, 152);
            this.OpenDataBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.OpenDataBtn.Name = "OpenDataBtn";
            this.OpenDataBtn.Size = new System.Drawing.Size(53, 30);
            this.OpenDataBtn.TabIndex = 5;
            this.OpenDataBtn.Text = "OPEN";
            this.OpenDataBtn.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OpenDataBtn.Click += new System.EventHandler(this.OpenDataBtn_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.OpenDataBtn);
            this.Controls.Add(this.TokenBtn);
            this.Controls.Add(this.DataFoldTextBox);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.TokenTextBox);
            this.Controls.Add(this.uiLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox TokenTextBox;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox DataFoldTextBox;
        private Sunny.UI.UIButton TokenBtn;
        private Sunny.UI.UIButton OpenDataBtn;
    }
}