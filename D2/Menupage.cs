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
    public partial class Menupage : Form
    {
        public Menupage()
        {
            InitializeComponent();
        }

        private void gatestg_btn_Click(object sender, EventArgs e)
        {       
            PulserInputsPage PI = new PulserInputsPage();
            PI.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Featurespage FP = new Featurespage();
            FP.ShowDialog();
        }

        private void Menupage_FormClosing(object sender, FormClosingEventArgs e)
        {
            const string message = "Are you sure that you would like to cancel the Application?";
            const string caption = "Cancel Application";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                Environment.Exit(0);
        }

        private void MainHome_btn_Click(object sender, EventArgs e)
        {
            Selectprofile sp = new Selectprofile();
            sp.Show();
            Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReceiverInputPage RI = new ReceiverInputPage();
            RI.Show();

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
