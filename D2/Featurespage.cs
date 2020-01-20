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
    public partial class Featurespage : Form
    {
        bool VectorButtonClicked = true;
        public Featurespage()
        {
            InitializeComponent();
        }

        private void velocity_btn_Click(object sender, EventArgs e)
        {
            if (VectorButtonClicked)
            {
                velocity_Box.Visible = true;
                range_Box.Visible = false;
                zero_Box.Visible = false;
                Delay_Box.Visible = false;
            }
           
        }

        private void menu_btn_Click(object sender, EventArgs e)
        {
            Close();
            Menupage R = new Menupage();
            R.Show();
        }

        private void range_btn_Click(object sender, EventArgs e)
        {
            if (VectorButtonClicked)
            {
                range_Box.Visible = true;
                velocity_Box.Visible = false;
                // range_Box.Visible = false;
                zero_Box.Visible = false;
                Delay_Box.Visible = false;
            }
           
        }

        private void zero_btn_Click(object sender, EventArgs e)
        {
            if (VectorButtonClicked)
            {
                zero_Box.Visible = true;
                velocity_Box.Visible = false;
                range_Box.Visible = false;
                // zero_Box.Visible = false;
                Delay_Box.Visible = false;
            }
           
        }

        private void delay_btn_Click(object sender, EventArgs e)
        {
            if (VectorButtonClicked)
            {
                Delay_Box.Visible = true;
                velocity_Box.Visible = false;
                range_Box.Visible = false;
                zero_Box.Visible = false;                
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void Featurespage_Load(object sender, EventArgs e)
        {
            textBox3.Text = "sin\u03BC" +" "+"Sec";
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BasicCancel_btn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
