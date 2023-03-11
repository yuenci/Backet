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
            this.SuspendLayout();
            // 
            // taskCard1
            // 
            this.taskCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.taskCard1.Location = new System.Drawing.Point(241, 92);
            this.taskCard1.Name = "taskCard1";
            this.taskCard1.Size = new System.Drawing.Size(290, 240);
            this.taskCard1.TabIndex = 0;
            // 
            // CardTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.taskCard1);
            this.Name = "CardTest";
            this.Text = "CardTest";
            this.ResumeLayout(false);

        }

        #endregion

        private UI_Conponents.TaskCard taskCard1;
    }
}