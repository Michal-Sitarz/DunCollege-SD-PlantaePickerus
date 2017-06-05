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
    public partial class MyHouse : Form
    {
        private string dbPath = @"C:\Users\Public\PlantaePickerus\PPdatabase.db";
        private string username;
        private string roomName;
        private int roomID;
        private List<Room> roomList;
        private List<string> roomNamesList;

        public MyHouse(string _username)
        {
            username = _username;
            InitializeComponent();
            fillListBox();
        }

        //ListBox Rooms

        public void fillListBox()
        {
            retrieveListOfRooms(); //this reads from DB

            //clear items
            listBoxRooms.DataSource = null;

            roomNamesList = new List<string>();
            //use roomNames from List of all entries from DB
            foreach (Room r in roomList)
            {
                roomNamesList.Add(r.roomName);
            }

            //sort list alphabetically
            roomNamesList.Sort();

            //fill the listbox with list <of strings>
            listBoxRooms.DataSource = roomNamesList;

            //unselect any item (by default)
            listBoxRooms.ClearSelected();

        }

        // method to retrieve list of rooms from DB
        private void retrieveListOfRooms()
        {
            //
            //SQLite database connection
            string connectionString = " Data Source = " + dbPath + "; Version=3; ";
            using (SQLiteConnection dbCon = new SQLiteConnection(connectionString))
            {
                try
                {
                    //open connection
                    dbCon.Open();

                    //perform SELECT Query:
                    string selectQuery = "SELECT roomID, roomName, usernameFK FROM rooms WHERE usernameFK = '" + username + "'";
                    using (SQLiteCommand command = new SQLiteCommand(selectQuery, dbCon))
                    {

                        using (SQLiteDataReader data = command.ExecuteReader())
                        {
                            try
                            {
                                //fill the data into List
                                roomList = new List<Room>();
                                while (data.Read())
                                {
                                    // set values using: my own SETter
                                    /*
                                    Room r = new Room();
                                    r.setRoomID((int)data["roomID"]);
                                    r.setRoomName((string)data["roomName"]);
                                    roomList.Add(r);
                                    */

                                    // set values using: C# {set}

                                    Room r = new Room();
                                    r.roomID = Convert.ToInt32(data["roomID"]);
                                    r.roomName = (string)data["roomName"];
                                    roomList.Add(r);


                                    // set values using: C# 100% way
                                    /*
                                    roomList.Add(new Room
                                    {
                                        roomID = (int)data["roomID"],
                                        roomName = (string)data["roomName"],
                                    });
                                    */

                                }
                            }
                            catch (Exception)
                            {
                                throw;
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
                //end of: exceptions handling

            } //end of: "using" >> object disposed

            //END: SQLite database connection
            //
        }

        /// EVENTS

        //listBoxRooms: double-click
        private void listBoxRooms_DoubleClick(object sender, EventArgs e)
        {
            //check if the item has been selected
            if (listBoxRooms.SelectedItem != null)
            {
                roomName = listBoxRooms.SelectedItem.ToString();
                roomID = 0;
                //search in ListRooms for this roomName and get the roomID assigned to it
                foreach (Room r in roomList)
                {
                    if (r.roomName == roomName)
                    {
                        roomID = r.roomID;
                    }
                }
                //doublecheck, if the roomID has been found
                if (roomID != 0)
                {
                    MyRoom myroom = new MyRoom(roomID, roomName);
                    myroom.ShowDialog();
                }

            }
        }


        //MAIN BUTTONS

        // Refresh List
        private void buttonRefreshList_Click(object sender, EventArgs e)
        {
            fillListBox();
        }

        // Add Room
        private void buttonAddRoom_Click(object sender, EventArgs e)
        {
            MyHouse_AddRoom addRoom = new MyHouse_AddRoom(username, roomNamesList);
            addRoom.ShowDialog();

            //refresh listBoxRooms after AddRoom form is closed
            fillListBox();
        }

        // Edit Room
        private void buttonEditRoom_Click(object sender, EventArgs e)
        {
            //check which room to edit
            if (listBoxRooms.SelectedItem != null)
            {
                string selectedRoomName = listBoxRooms.SelectedItem.ToString();

                MyHouse_EditRoom addRoom = new MyHouse_EditRoom(username, selectedRoomName, roomNamesList);
                addRoom.ShowDialog();

                //refresh listBoxRooms after EditRoom form is closed
                fillListBox();

            }
            else
            {
                MessageBox.Show("Please select the room to EDIT from the list.");
            }
        }

        // Delete Room
        private void buttonDeleteRoom_Click(object sender, EventArgs e)
        {
            //check which room to delete
            if (listBoxRooms.SelectedItem != null)
            {
                string selectedRoomName = listBoxRooms.SelectedItem.ToString();

                //confirm user's intension to delete
                DialogResult deleteMessage = MessageBox.Show("Are you sure you want to delete the room: \n" + selectedRoomName + " \nand all of its spots and plants?", "Delete: " + selectedRoomName, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (deleteMessage == DialogResult.OK)
                {
                    string selectedRoomNameDisplay = selectedRoomName;
                    //check if username contains special character: [']
                    if (selectedRoomName.Contains("'"))
                    {
                        selectedRoomName = selectedRoomName.Replace("'", "''");
                    }

                    //delete this entry from the DB
                    string queryDeletePrep = "DELETE FROM rooms WHERE roomName = '" + selectedRoomName + "' AND usernameFK = '" + username + "'";
                    string queryDelete = queryDeletePrep;
                    Query q = new Query(queryDelete);
                    if (q.success())
                    {
                        MessageBox.Show("Room: " + selectedRoomNameDisplay + "\nhas been successfully deleted.");
                    }

                    //auto-refresh list of the rooms
                    fillListBox();
                }

            }
            else
            {
                MessageBox.Show("Please select the room to DELETE from the list.");
            }

        }


        //button GoBack
        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //button Logout
        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                f.Hide();
            }
            Login login = new Login();
            login.Show();
        }

        //onClose: Exit
        private void MyHouse_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }



        //
        //TESTS here
        public void testAddRoom()
        {
            List<string> l = new List<string>();

            //make 10 instances (=10 rows in a DB table)
            for (int i = 1; i <= 10; i++)
            {
                string queryInsert = "INSERT INTO rooms(roomID, roomName, usernameFK) VALUES(NULL,'" + username + "_room" + i + "','" + username + "')";
                Query q = new Query(queryInsert);
                if (q.success())
                {
                    string success = "success" + i;
                    l.Add(success);
                }
            }

            //show which one was successfully added to DB
            string f = "";
            foreach (string n in l)
            {
                f += n + "\n";
            }
            MessageBox.Show(f);
        }
        
    }
}
