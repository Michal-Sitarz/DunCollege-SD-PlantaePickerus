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
    public partial class MyHouse_AddRoom : Form
    {
        private string username;
        private List<string> roomNamesList;
        private string newRoomName = "";

        public MyHouse_AddRoom(string _username, List<string> _roomNamesList)
        {
            InitializeComponent();
            roomNamesList = _roomNamesList;
            username = _username;

            //place cursor in the textBox (by default)
            textBoxRoomName.Select();

        }

        /// GLOBAL methods

        private void addRoomName()
        {
            //check if the user entered any name
            if (newRoomName == "")
            {
                MessageBox.Show("Please enter the name for the room.");
            }

            else
            {
                //check if this name already exists (in user's room list)
                bool foundSameRoomName = false;
                foreach (string r in roomNamesList)
                {
                    if (r == newRoomName)
                    {
                        foundSameRoomName = true;
                    }
                }

                if (foundSameRoomName == true)
                {
                    MessageBox.Show("You already have the room with this name. \n\nHint: Try to add number index to the room name, \nif you've got multiple similar rooms.\nExample:''bedroom 1'',''bedroom 2''");
                }
                else
                {
                    string newRoomNameDisplay = newRoomName;

                    //check if the roomName contains special character: [']
                    if (newRoomName.Contains("'"))
                    {
                        newRoomName = newRoomName.Replace("'", "''");
                    }

                    // add room to the database
                    string queryInsert = "INSERT INTO rooms(roomID, roomName, usernameFK) VALUES(NULL,'" + newRoomName + "','" + username + "')";
                    Query q = new Query(queryInsert);
                    if (q.success())
                    {
                        MessageBox.Show("Room: " + newRoomNameDisplay + "\nhas been added successfully.");
                        this.Hide();
                    }

                }

            }
        }

        /// events

        private void textBoxRoomName_TextChanged(object sender, EventArgs e)
        {
            newRoomName = textBoxRoomName.Text;
        }

        //button OK
        private void buttonOK_Click(object sender, EventArgs e)
        {
            addRoomName();
        }

        //press Enter (in the textBox)
        private void textBoxRoomName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addRoomName();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void MyHouse_AddRoom_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }




    }
}
