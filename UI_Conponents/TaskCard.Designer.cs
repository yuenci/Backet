namespace Backet.UI_Conponents
{
    partial class TaskCard
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.ProcessBar = new Sunny.UI.UIProcessBar();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiAvatar2 = new Sunny.UI.UIAvatar();
            this.TaskName = new Sunny.UI.UILabel();
            this.IconsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.uiPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.uiLabel2);
            this.uiPanel1.Controls.Add(this.ProcessBar);
            this.uiPanel1.Controls.Add(this.uiLabel1);
            this.uiPanel1.Controls.Add(this.uiAvatar2);
            this.uiPanel1.Controls.Add(this.TaskName);
            this.uiPanel1.Controls.Add(this.IconsPanel);
            this.uiPanel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.uiPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.uiPanel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel1.Location = new System.Drawing.Point(5, 5);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Radius = 10;
            this.uiPanel1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(232)))), ((int)(((byte)(231)))));
            this.uiPanel1.RectSize = 2;
            this.uiPanel1.Size = new System.Drawing.Size(280, 230);
            this.uiPanel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel1.TabIndex = 2;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel2.Location = new System.Drawing.Point(12, 191);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(201, 23);
            this.uiLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel2.TabIndex = 8;
            this.uiLabel2.Text = "Last updated: 10 Dec, 2022";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ProcessBar
            // 
            this.ProcessBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.ProcessBar.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ProcessBar.Location = new System.Drawing.Point(16, 169);
            this.ProcessBar.MinimumSize = new System.Drawing.Size(70, 3);
            this.ProcessBar.Name = "ProcessBar";
            this.ProcessBar.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(153)))), ((int)(((byte)(56)))));
            this.ProcessBar.Size = new System.Drawing.Size(249, 7);
            this.ProcessBar.Style = Sunny.UI.UIStyle.Custom;
            this.ProcessBar.TabIndex = 7;
            this.ProcessBar.Text = "uiProcessBar1";
            this.ProcessBar.Value = 50;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel1.Location = new System.Drawing.Point(45, 126);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(201, 23);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 6;
            this.uiLabel1.Text = "Start: Nov 12";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiAvatar2
            // 
            this.uiAvatar2.AvatarSize = 25;
            this.uiAvatar2.BackColor = System.Drawing.Color.Transparent;
            this.uiAvatar2.FillColor = System.Drawing.Color.Transparent;
            this.uiAvatar2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiAvatar2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiAvatar2.Location = new System.Drawing.Point(9, 124);
            this.uiAvatar2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiAvatar2.Name = "uiAvatar2";
            this.uiAvatar2.Size = new System.Drawing.Size(30, 30);
            this.uiAvatar2.Style = Sunny.UI.UIStyle.Custom;
            this.uiAvatar2.Symbol = 57379;
            this.uiAvatar2.SymbolSize = 25;
            this.uiAvatar2.TabIndex = 5;
            this.uiAvatar2.Text = "uiAvatar2";
            // 
            // TaskName
            // 
            this.TaskName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TaskName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskName.Location = new System.Drawing.Point(12, 67);
            this.TaskName.Name = "TaskName";
            this.TaskName.Size = new System.Drawing.Size(253, 45);
            this.TaskName.Style = Sunny.UI.UIStyle.Custom;
            this.TaskName.TabIndex = 1;
            this.TaskName.Text = "uiLabel1uiLabel1uiLabel1uiLabel1uiLabel1";
            this.TaskName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TaskName.Click += new System.EventHandler(this.TaskName_Click);
            // 
            // IconsPanel
            // 
            this.IconsPanel.Location = new System.Drawing.Point(16, 13);
            this.IconsPanel.Name = "IconsPanel";
            this.IconsPanel.Size = new System.Drawing.Size(180, 35);
            this.IconsPanel.TabIndex = 0;
            // 
            // TaskCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.Controls.Add(this.uiPanel1);
            this.Name = "TaskCard";
            this.Size = new System.Drawing.Size(290, 240);
            this.uiPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel uiPanel1;
        private System.Windows.Forms.FlowLayoutPanel IconsPanel;
        private Sunny.UI.UILabel TaskName;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIProcessBar ProcessBar;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIAvatar uiAvatar2;
    }
}
