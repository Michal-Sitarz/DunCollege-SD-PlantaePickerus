using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlantaePickerus_proto
{
    public partial class Login : Form
    {
        private string username;
        private string password;
        private string connectionString;
        private string dbPath = @"C:\Users\Public\PlantaePickerus\PPdatabase.db";

        private List<string> dbQueries = new List<string>();

        //ctor
        public Login()
        {
            InitializeComponent();

            //
            //SQLite database
            connectionString = " Data Source = " + dbPath + "; Version=3; ";

            //check, if the database doesn't exist (as a local file)
            if (!File.Exists(dbPath))
            {

                //create DB file
                try
                {
                    SQLiteConnection.CreateFile(dbPath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Can't access local hard drive.");
                }

                //create DB tables
                using (SQLiteConnection dbCon = new SQLiteConnection(connectionString))
                {
                    addQueriesList();

                    try
                    {
                        dbCon.Open();

                        foreach (string listQuery in dbQueries)
                        {
                            using (SQLiteCommand command = new SQLiteCommand(listQuery, dbCon))
                            {
                                command.ExecuteNonQuery();
                            }
                        }

                        dbCon.Close();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }


            }

        }
        //END of: ctor

        private void addQueriesList()
        {
            dbQueries.Add("CREATE TABLE users(username TEXT PRIMARY KEY UNIQUE NOT NULL, password TEXT NOT NULL)");
            dbQueries.Add("CREATE TABLE rooms(roomID INTEGER PRIMARY KEY, roomName TEXT NOT NULL, usernameFK TEXT NOT NULL REFERENCES users(username))");
            dbQueries.Add("CREATE TABLE spots(spotID INTEGER PRIMARY KEY, spotName TEXT NOT NULL, spotSunlight INTEGER, spotHumidity INTEGER, spotDirection TEXT, spotDrafts BOOLEAN, roomIDFK INTEGER NOT NULL REFERENCES rooms(roomID))");
            dbQueries.Add("CREATE TABLE plants(plantID INTEGER PRIMARY KEY, plantName TEXT NOT NULL, plantLatinName TEXT, plantType TEXT, plantSize TEXT, plantBlooming BOOLEAN, plantGrowingSpeed TEXT, requireSunlight INTEGER, requireHumidity INTEGER, requireDirection TEXT, coldDrafts BOOLEAN, spotIDFK INTEGER NOT NULL REFERENCES spots(spotID))");
        }

        //login method
        private void loginToSystem()
        {
            string dbUsername = "";
            string dbPassword = "";

            // retrieve data from SQLite database
            using (SQLiteConnection dbCon = new SQLiteConnection(connectionString))
            {
                string readUsernameQuery = "SELECT * FROM users WHERE username='" + username + "'"; //SELECT typed-in username

                try
                {

                    dbCon.Open();


                    using (SQLiteCommand commandUsername = new SQLiteCommand(readUsernameQuery, dbCon))
                    {
                        using (SQLiteDataReader dataUsername = commandUsername.ExecuteReader())
                        {
                            if (dataUsername.Read())
                            {
                                dbUsername = dataUsername["username"].ToString();
                                dbPassword = dataUsername["password"].ToString();
                            }
                        }

                    }

                    dbCon.Close();

                }
                catch (Exception)
                {
                    throw;
                }


            }


            //username/password validation
            if (username == dbUsername)
            {
                if (password == dbPassword)
                {
                    this.Hide();
                    Main main = new Main(username);
                    main.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Wrong password. \n Try Again!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    textBoxPassword.SelectAll();
                }
            }
            else
            {
                MessageBox.Show("Wrong username. \n\n Try again \n or create new account. ",
                                "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }


        //TEXTBOXES

        //username textbox
        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            username = textBoxUsername.Text;
        }
        private void textBoxUsername_MouseDown(object sender, MouseEventArgs e)
        {

        }
        private void textBoxUsername_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBoxUsername.SelectAll();
        }

        private void textBoxUsername_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                textBoxUsername.SelectAll();
            }
        }
        private void textBoxUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginToSystem();
            }
        }

        //password textbox
        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            password = textBoxPassword.Text;
            textBoxPassword.PasswordChar = '•';

        }
        private void textBoxPassword_MouseDown(object sender, MouseEventArgs e)
        {
            textBoxPassword.SelectAll();
        }
        private void textBoxPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                textBoxPassword.SelectAll();
            }
        }
        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginToSystem();
            }
        }


        //button: Login
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            loginToSystem();
        }


        // button: Create an account
        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {

            CreateAccount createAcc = new CreateAccount();
            createAcc.ShowDialog();
        }

        //onClose event
        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


    }
}
