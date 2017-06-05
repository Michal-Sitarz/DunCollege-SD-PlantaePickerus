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
    public partial class Main : Form
    {
        private string userToSend;

        public Main(string _username)
        {
            InitializeComponent();

            //logged-in username
            string username = _username;
            labelUsername.Text = username;
            userToSend = username;
        }


        //MAIN BUTTONS
        private void buttonManageMyHouse_Click(object sender, EventArgs e)
        {
            MyHouse myHouse = new MyHouse(userToSend);
            myHouse.ShowDialog();
        }

        private void buttonFindPlant_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Functionality not available in prototype version.");
        }

        private void buttonFindSpot_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Functionality not available in prototype version.");
        }

        //button Logout
        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        //onClose: Exit
        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }


    }
}
