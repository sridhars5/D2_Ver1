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
    public partial class PulserInputsPage : Form
    {
        bool VectorButtonClicked = true;
        public PulserInputsPage()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void votage_btn_Click(object sender, EventArgs e)
        {
            if (VectorButtonClicked)
            {
                voltage_Box.Visible = true;
                Frequency_Box.Visible = false;
                Damping_Box.Visible = false;
               
            }
        }

        private void Frequency_btn_Click(object sender, EventArgs e)
        {
            if (VectorButtonClicked)
            {
                voltage_Box.Visible = false;
                Frequency_Box.Visible =true ;
                Damping_Box.Visible = false;

            }
        }

        private void Damping_btn_Click(object sender, EventArgs e)
        {
            if (VectorButtonClicked)
            {
                voltage_Box.Visible = false;
                Frequency_Box.Visible = false;
                Damping_Box.Visible = true;

            }
        }

        private void menu_btn_Click(object sender, EventArgs e)
        {
            Close();          
        }
    }
}
