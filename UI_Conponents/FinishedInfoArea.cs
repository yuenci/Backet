using System.Drawing;
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
        public void InitDate(string endDate, string updateDate)
        {
            EndLabel.Text = "End: " + Tools.ISO8601ToDDMMYY(endDate);
            UpdateDate.Text = "Last updated: " + Tools.ISO8601ToDDMMYY(updateDate);
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
