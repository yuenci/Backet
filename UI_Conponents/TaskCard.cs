using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backet.UI_Conponents
{
    public partial class TaskCard : UserControl
    {
        public TaskCard()
        {
            InitializeComponent();
            InitIcons();
        }
        private void InitIcons()
        {
            AddIcons(Properties.Resources.githubIcon);
            AddIcons(Properties.Resources.figmaIcon);
            AddIcons(Properties.Resources.fileIcon);
        }

        private void AddIcons(Image image)
        {
            PictureBox pictureBox = new PictureBox
            {
                Image = image,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Size = new Size(30, 30)
            };
            pictureBox.Cursor = Cursors.Hand;

            IconsPanel.Controls.Add(pictureBox);
        }
    }
}
