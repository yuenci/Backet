using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backet.Forms
{
    public partial class Details : Form
    {
        public Details()
        {
            InitializeComponent();
        }

        private void MoreOptBtn_Click(object sender, EventArgs e)
        {
            Submit submit = new Submit();
        }
    }
}
