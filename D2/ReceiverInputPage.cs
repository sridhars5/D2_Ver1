using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D2
{
    public partial class ReceiverInputPage : Form
    {

        bool VectorButtonClicked = true;
        public ReceiverInputPage()
        {
            InitializeComponent();
        }

        private void velocity_btn_Click(object sender, EventArgs e)
        {
            if (VectorButtonClicked)
            {
                Gain_Box.Visible = true;
                Filter_Box.Visible = false;
                Signal_Box.Visible = false;               
            }
        }

        private void range_btn_Click(object sender, EventArgs e)
        {
            if (VectorButtonClicked)
            {
                Gain_Box.Visible = false;
                Filter_Box.Visible = true;
                Signal_Box.Visible = false;
            }
        }

        private void zero_btn_Click(object sender, EventArgs e)
        {
            if (VectorButtonClicked)
            {
                Gain_Box.Visible = false;
                Filter_Box.Visible = false;
                Signal_Box.Visible = true;
            }
        }

        private void menu_btn_Click(object sender, EventArgs e)
        {
            Close();
            Menupage R = new Menupage();
            R.Show();
        }

        private void Rceivercancel_btn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
