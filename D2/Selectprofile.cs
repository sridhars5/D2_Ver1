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
    public partial class Selectprofile : Form
    {
        public Selectprofile()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
          
            Filesetup F = new Filesetup();         
            F.ShowDialog();
            Visible = false;
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
           
            HomePage hp = new HomePage();         
            hp.Show();
            Visible = false;
        }

        private void Selectprofile_FormClosing(object sender, FormClosingEventArgs e)
        {
            const string message = "Are you sure that you would like to cancel the Application?";
            const string caption = "Cancel Application";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                Environment.Exit(0);
        }

        private void SelectProf_btn_Click(object sender, EventArgs e)
        {
            Filesetup F = new Filesetup();
            F.ShowDialog();
            Visible = false;
        }

        private void Filename_btn_Click(object sender, EventArgs e)
        {
            Filesetup F = new Filesetup();
            F.ShowDialog();
            Visible = false;
        }
    }
}
