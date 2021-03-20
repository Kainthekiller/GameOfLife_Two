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
    public partial class SizeOfAreaDialog : Form
    {
        public SizeOfAreaDialog()
        {
            InitializeComponent();
        }
        
        public decimal height
        {
            get
            {
                return numericUpDown_High.Value;
            }
            set
            {
                numericUpDown_High.Value = value;
            }
        }

        public decimal width
        {
            get
            {
                return numericUpDown_Width.Value;
            }
            set
            {
                numericUpDown_Width.Value = value;
            }

        }
    }
}
