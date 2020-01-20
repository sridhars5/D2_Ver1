using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;

namespace D2
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

      
        private void label2_Click(object sender, EventArgs e)
        {
            Hide();
            var Selectprofile = new Selectprofile();
            Selectprofile.FormClosed += (s, args) => Close();
            Selectprofile.Show();
        }
     
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            panel1.Dock = DockStyle.Fill;

          

        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            //  Font font = new Font("alien-encounters-solid_[allfont.net].ttf", 12.0f);
            //  FontFamily family = new FontFamily("alien-encounters-solid_[allfont.net].ttf");

            HomePage pfc = new HomePage();
           // pfc.Font.(@"C:\MyFont.ttf");
          //  myLabel.Font = new Font(pfc.Families[0], 14, FontStyle.Regular);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Hide();
            var Selectprofile = new Selectprofile();
            Selectprofile.FormClosed += (s, args) => Close();
            Selectprofile.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
       
        private void HomePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Are You Sure To Exit Application ?", "Dialog Title", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Environment.Exit(0);
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void createpjt_btm_Click(object sender, EventArgs e)
        {
            Hide();
            var Selectprofile = new Selectprofile();
            Selectprofile.FormClosed += (s, args) => Close();
            Selectprofile.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 f = new Form1();
            f.Show();
        }
    }
   
}
