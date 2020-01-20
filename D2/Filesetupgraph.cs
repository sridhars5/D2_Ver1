using D2.Properties;
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
    public partial class Filesetupgraph : Form
    {
        public Filesetupgraph()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Close();
            var Filesetup = new Filesetup();
            Filesetup.FormClosed += (s, args) => Close();
            Filesetup.Show();
        }

        private void Filesetupgraph_Load(object sender, EventArgs e)
        {

           // textBox1.Text = Filesetup.sendtext;

        }

        private void Filesetupgraph_FormClosing(object sender, FormClosingEventArgs e)
        {
        //    if (e.CloseReason == CloseReason.UserClosing)
        //    {
        //        DialogResult result = MessageBox.Show("Do you want to exit the whole application ?", "Close Application", MessageBoxButtons.YesNo);
        //        if (result == DialogResult.Yes)
        //        {
        //            MessageBox.Show("The application has been closed successfully.", "Application Closed!", MessageBoxButtons.OK);
        //            Environment.Exit(0);
        //        }
        //        else
        //        {
        //            e.Cancel = true;
        //        }
        //    }
        //    else
        //    {
        //        e.Cancel = true;
        //    }
        }

        

        private void con_btn_Click(object sender, EventArgs e)
        {          
            Resultgraph R = new Resultgraph();
            R.Show();
            Visible = false;
            
        }
    }
}
