using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D2.Properties
{
    public partial class Resultgraph : Form
    {
        public Resultgraph()
        {
            InitializeComponent();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Selectprofile sp = new Selectprofile();
            sp.Show();
            Visible = false;
        }

        private void menu_btn_Click(object sender, EventArgs e)
        {
            Hide();
            Menupage R = new Menupage();
            R.Show();
           
        }
    }
}
