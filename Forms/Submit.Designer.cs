namespace Backet
{
    partial class Submit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Submit));
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.SubmitBtn = new Sunny.UI.UISymbolButton();
            this.RepoURL = new Sunny.UI.UITextBox();
            this.FigmaURL = new Sunny.UI.UITextBox();
            this.LocalPath = new Sunny.UI.UITextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.TaskStatusComboBox = new Sunny.UI.UIComboBox();
            this.SuspendLayout();
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel1.Location = new System.Drawing.Point(15, 25);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(100, 23);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "GitHub URL";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel2.Location = new System.Drawing.Point(15, 103);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(100, 23);
            this.uiLabel2.TabIndex = 1;
            this.uiLabel2.Text = "Figma URL";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel3.Location = new System.Drawing.Point(15, 183);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(100, 23);
            this.uiLabel3.TabIndex = 2;
            this.uiLabel3.Text = "Local Path";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SubmitBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitBtn.Location = new System.Drawing.Point(19, 345);
            this.SubmitBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(453, 35);
            this.SubmitBtn.TabIndex = 3;
            this.SubmitBtn.Text = "   Submit";
            this.SubmitBtn.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // RepoURL
            // 
            this.RepoURL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RepoURL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepoURL.Location = new System.Drawing.Point(19, 53);
            this.RepoURL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RepoURL.MinimumSize = new System.Drawing.Size(1, 16);
            this.RepoURL.Name = "RepoURL";
            this.RepoURL.ShowText = false;
            this.RepoURL.Size = new System.Drawing.Size(452, 29);
            this.RepoURL.TabIndex = 4;
            this.RepoURL.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.RepoURL.Watermark = "";
            // 
            // FigmaURL
            // 
            this.FigmaURL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FigmaURL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FigmaURL.Location = new System.Drawing.Point(19, 131);
            this.FigmaURL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FigmaURL.MinimumSize = new System.Drawing.Size(1, 16);
            this.FigmaURL.Name = "FigmaURL";
            this.FigmaURL.ShowText = false;
            this.FigmaURL.Size = new System.Drawing.Size(452, 29);
            this.FigmaURL.TabIndex = 5;
            this.FigmaURL.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.FigmaURL.Watermark = "";
            // 
            // LocalPath
            // 
            this.LocalPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LocalPath.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocalPath.Location = new System.Drawing.Point(19, 211);
            this.LocalPath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LocalPath.MinimumSize = new System.Drawing.Size(1, 16);
            this.LocalPath.Name = "LocalPath";
            this.LocalPath.ShowText = false;
            this.LocalPath.Size = new System.Drawing.Size(452, 29);
            this.LocalPath.TabIndex = 5;
            this.LocalPath.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.LocalPath.Watermark = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(104, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "*";
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel4.Location = new System.Drawing.Point(15, 256);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(100, 23);
            this.uiLabel4.TabIndex = 7;
            this.uiLabel4.Text = "Task Status";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TaskStatusComboBox
            // 
            this.TaskStatusComboBox.DataSource = null;
            this.TaskStatusComboBox.FillColor = System.Drawing.Color.White;
            this.TaskStatusComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskStatusComboBox.Items.AddRange(new object[] {
            "Todo",
            "In Progress",
            "Done"});
            this.TaskStatusComboBox.Location = new System.Drawing.Point(19, 283);
            this.TaskStatusComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TaskStatusComboBox.MinimumSize = new System.Drawing.Size(63, 0);
            this.TaskStatusComboBox.Name = "TaskStatusComboBox";
            this.TaskStatusComboBox.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.TaskStatusComboBox.Size = new System.Drawing.Size(452, 29);
            this.TaskStatusComboBox.TabIndex = 8;
            this.TaskStatusComboBox.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.TaskStatusComboBox.Watermark = "";
            // 
            // Submit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(484, 392);
            this.Controls.Add(this.TaskStatusComboBox);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LocalPath);
            this.Controls.Add(this.FigmaURL);
            this.Controls.Add(this.RepoURL);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Submit";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Submit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UISymbolButton SubmitBtn;
        private Sunny.UI.UITextBox RepoURL;
        private Sunny.UI.UITextBox FigmaURL;
        private Sunny.UI.UITextBox LocalPath;
        private System.Windows.Forms.Label label1;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UIComboBox TaskStatusComboBox;
    }
}