using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife_Two
{
    public partial class MilliSecondsDialog : Form
    {
        public MilliSecondsDialog()
        {
            InitializeComponent();
        }
        public decimal timerMillSec
        {
            get
            {
                return MillSecUpnDwn.Value;
            }
            set
            {
                MillSecUpnDwn.Value = value;
            }

        }
    }
}
