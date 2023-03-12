namespace Backet.UI_Conponents
{
    partial class FinishedInfoArea
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
            this.ComplateLabel = new Sunny.UI.UISymbolButton();
            this.EndLabel = new Sunny.UI.UILabel();
            this.targetIcon = new Sunny.UI.UIAvatar();
            this.UpdateDate = new Sunny.UI.UILabel();
            this.SuspendLayout();
            // 
            // ComplateLabel
            // 
            this.ComplateLabel.BackColor = System.Drawing.Color.Transparent;
            this.ComplateLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComplateLabel.Enabled = false;
            this.ComplateLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComplateLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComplateLabel.Location = new System.Drawing.Point(12, 45);
            this.ComplateLabel.MinimumSize = new System.Drawing.Size(1, 1);
            this.ComplateLabel.Name = "ComplateLabel";
            this.ComplateLabel.Radius = 10;
            this.ComplateLabel.Size = new System.Drawing.Size(255, 25);
            this.ComplateLabel.Style = Sunny.UI.UIStyle.Custom;
            this.ComplateLabel.Symbol = 78;
            this.ComplateLabel.TabIndex = 9;
            this.ComplateLabel.Text = "Completed";
            this.ComplateLabel.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // EndLabel
            // 
            this.EndLabel.BackColor = System.Drawing.Color.Transparent;
            this.EndLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndLabel.Location = new System.Drawing.Point(48, 9);
            this.EndLabel.Name = "EndLabel";
            this.EndLabel.Size = new System.Drawing.Size(201, 25);
            this.EndLabel.Style = Sunny.UI.UIStyle.Custom;
            this.EndLabel.TabIndex = 11;
            this.EndLabel.Text = "End: Nov 12";
            this.EndLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // targetIcon
            // 
            this.targetIcon.AvatarSize = 25;
            this.targetIcon.BackColor = System.Drawing.Color.Transparent;
            this.targetIcon.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.targetIcon.Location = new System.Drawing.Point(12, 9);
            this.targetIcon.MinimumSize = new System.Drawing.Size(1, 1);
            this.targetIcon.Name = "targetIcon";
            this.targetIcon.Size = new System.Drawing.Size(30, 30);
            this.targetIcon.Style = Sunny.UI.UIStyle.Custom;
            this.targetIcon.Symbol = 57589;
            this.targetIcon.SymbolSize = 25;
            this.targetIcon.TabIndex = 10;
            this.targetIcon.Text = "uiAvatar1";
            // 
            // UpdateDate
            // 
            this.UpdateDate.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.UpdateDate.BackColor = System.Drawing.Color.Transparent;
            this.UpdateDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateDate.Location = new System.Drawing.Point(8, 76);
            this.UpdateDate.Name = "UpdateDate";
            this.UpdateDate.Size = new System.Drawing.Size(201, 23);
            this.UpdateDate.Style = Sunny.UI.UIStyle.Custom;
            this.UpdateDate.TabIndex = 12;
            this.UpdateDate.Text = "Last updated: 10 Dec, 2022";
            this.UpdateDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FinishedInfoArea
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.UpdateDate);
            this.Controls.Add(this.ComplateLabel);
            this.Controls.Add(this.EndLabel);
            this.Controls.Add(this.targetIcon);
            this.Name = "FinishedInfoArea";
            this.Size = new System.Drawing.Size(270, 111);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolButton ComplateLabel;
        private Sunny.UI.UILabel EndLabel;
        private Sunny.UI.UIAvatar targetIcon;
        private Sunny.UI.UILabel UpdateDate;
    }
}
