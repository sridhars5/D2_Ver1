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
    public partial class LogoPage : Form
    {
        private System.Windows.Forms.Timer formClosingTimer;
        private int ticks;

      
        public LogoPage()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void LogoPage_Load(object sender, EventArgs e)
        {
            formClosingTimer = new System.Windows.Forms.Timer();  // Creating a new timer 
            formClosingTimer.Tick += new EventHandler(CloseForm); // Defining tick event to invoke after a time period
            formClosingTimer.Interval = 2000; // Time Interval in miliseconds
            formClosingTimer.Start(); // Starting a timer           
              
        }
        private void CloseForm(object sender, EventArgs e)
        {
            formClosingTimer.Stop(); // Stoping timer. If we dont stop, function will be triggered in regular intervals
                                 HomePage form = new HomePage();
                                     form.Show();

            Hide(); // Closing the current form
           
        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            

        }


        public static void Main(string[] args)
        {

            Application.Run(new LogoPage());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
