using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlantaePickerus_proto
{
    public partial class CreateAccount : Form
    {
        private string newUsername = "";
        private string newPassword = "";

        private string dbPath = @"C:\Users\Public\PlantaePickerus\PPdatabase.db";

        public CreateAccount()
        {
            InitializeComponent();
        }


        //textboxes

        private void textBoxNewUsername_TextChanged(object sender, EventArgs e)
        {
            newUsername = textBoxNewUsername.Text;
        }

        private void textBoxNewPassword_TextChanged(object sender, EventArgs e)
        {
            newPassword = textBoxNewPassword.Text;
            textBoxNewPassword.PasswordChar = '•';
        }

        //button submit
        private void buttonSubmitNewUser_Click(object sender, EventArgs e)
        {
            List<string> allUsernames = new List<string>();
            string connectionString = " Data Source = " + dbPath + "; Version=3; ";

            //validate if the user typed-in any username (no empty field)
            if (newUsername == "")
            {
                MessageBox.Show("No username entered. \nPlease enter your username", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            //validate if the user typed-in any password
            else if (newPassword == "")
            {
                MessageBox.Show("No password entered. \nPlease enter password of your choice ", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            //check for special characters in: username
            else if (newUsername.Any(ch => !Char.IsLetterOrDigit(ch)))
            {
                MessageBox.Show("Only letters and numbers are allowed for Username.", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            //check for special characters in: password
            else if (newPassword.Any(ch => !Char.IsLetterOrDigit(ch)))
            {
                MessageBox.Show("Only letters and numbers are allowed for Password.", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            
            else
            {
                //connect to the SQLite database

                using (SQLiteConnection dbCon = new SQLiteConnection(connectionString))
                {
                    try
                    {
                        //open connection
                        dbCon.Open();

                        //check username entries
                        string checkUsernameQuery = "SELECT username FROM users"; //SELECT all usernames
                        using (SQLiteCommand commandUsername = new SQLiteCommand(checkUsernameQuery, dbCon))
                        {
                            using (SQLiteDataReader dataUsername = commandUsername.ExecuteReader())
                            {
                                //fill all of the usernames into List
                                while (dataUsername.Read())
                                {
                                    allUsernames.Add(dataUsername["username"].ToString());
                                }
                            }

                        }

                        //close connection
                        dbCon.Close();

                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }

                //check if the user exists already in the database
                bool foundSameUsername = false;
                foreach (string listElement in allUsernames)
                {
                    if (listElement == newUsername)
                    {
                        foundSameUsername = true;
                    }
                }

                //if found, then display message
                if (foundSameUsername)
                {
                    MessageBox.Show("Username: " + newUsername + " already exist. \nPlease choose different name.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                //if not, then querry insert
                else
                {

                    string newUsernameToDB = newUsername;
                    string newPasswordToDB = newPassword;
                    
                    using (SQLiteConnection dbCon = new SQLiteConnection(connectionString))
                    {
                        try
                        {
                            //open connection
                            dbCon.Open();

                            string insertQuery = "INSERT INTO users (username, password) VALUES ('" + newUsernameToDB + "', '" + newPasswordToDB + "')";
                            using (SQLiteCommand command = new SQLiteCommand(insertQuery, dbCon))
                            {
                                command.ExecuteNonQuery();
                            }

                            //close connection
                            dbCon.Close();

                            MessageBox.Show("Username: " + newUsernameToDB + " has been created succesfully!");
                            this.Hide();
                        }
                        catch (Exception)
                        {
                            throw;
                        }
                    }

                }

            }

        }

        // on-close
        private void CreateAccount_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }
    }
}





