using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlantaePickerus_proto
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        // timer of the Splash Screen >> 3 seconds (=3000ms)
        Timer tmr;
        private void SplashScreen_Shown(object sender, EventArgs e)
        {
            tmr = new Timer();
            tmr.Interval = 3000; //use 3000 (3sec) as default, decrease to 500 during development stage
            tmr.Start();
            tmr.Tick += tmrTick;
            
        }

        void tmrTick(object sender, EventArgs e)
        {
            tmr.Stop();
            //hide Splash Screen
            this.Hide();
            
            //show Main form
            Login login = new Login();
            login.Show();
            
            
        }


    }
}
