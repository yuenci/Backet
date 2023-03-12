using Backet.Properties;
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
    public partial class FinishedInfoArea : UserControl
    {
        public FinishedInfoArea()
        {
            InitializeComponent();
            InitStyle();
        }
        private void InitDate()
        {
            
        }

        private void InitStyle()
        {
            targetIcon.FillColor = Color.Transparent;
            targetIcon.ForeColor = Color.FromArgb(64, 64, 64);
            ComplateLabel.RectDisableColor = Color.Transparent;
            ComplateLabel.FillDisableColor = Color.FromArgb(193, 243, 213);
            ComplateLabel.ForeDisableColor = Color.FromArgb(1, 153, 56);
            




        }
    }
}
