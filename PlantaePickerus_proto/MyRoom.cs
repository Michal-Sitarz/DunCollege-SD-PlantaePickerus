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
    public partial class MyRoom : Form
    {
        private string dbPath = @"C:\Users\Public\PlantaePickerus\PPdatabase.db";
        private int roomID;
        private int spotID;
        private string spotName;
        private List<Spot> spotList;
        private List<string> spotNamesList;

        public MyRoom(int _roomID, string _roomName)
        {
            roomID = _roomID;
            InitializeComponent();
            fillListBoxSpots();

            labelRoomName.Text = _roomName;
        }

        //ListBox Spots

        public void fillListBoxSpots()
        {
            retrieveListOfSpots(); //this reads from DB

            //clear items
            listBoxSpots.DataSource = null;

            spotNamesList = new List<string>();
            //use spotNames from List of all entries from DB
            foreach (Spot s in spotList)
            {
                spotNamesList.Add(s.spotName);
            }

            //sort list alphabetically
            spotNamesList.Sort();

            //fill the listbox with list <of strings>
            listBoxSpots.DataSource = spotNamesList;

            //unselect any item (by default)
            listBoxSpots.ClearSelected();

        }

        // method to retrieve list of Spots from DB
        private void retrieveListOfSpots()
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
                    string selectQuery = "SELECT * FROM spots WHERE roomIDFK = '" + roomID + "'";
                    using (SQLiteCommand command = new SQLiteCommand(selectQuery, dbCon))
                    {

                        using (SQLiteDataReader data = command.ExecuteReader())
                        {
                            try
                            {
                                //fill the data into List
                                spotList = new List<Spot>();
                                while (data.Read())
                                {
                                    // set values using: C# {set}
                                    Spot s = new Spot();
                                    s.spotID = Convert.ToInt32(data["spotID"]);
                                    s.spotName = (string)data["spotName"];
                                    s.spotSunlight = Convert.ToInt32(data["spotSunlight"]);
                                    s.spotHumidity = Convert.ToInt32(data["spotHumidity"]);
                                    s.spotDirection = (string)data["spotDirection"];
                                    s.spotDrafts = (bool)data["spotDrafts"];
                                    spotList.Add(s);
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

        //listBoxSpots: double-click
        private void listBoxSpots_DoubleClick(object sender, EventArgs e)
        {
            //check if the item has been selected
            if (listBoxSpots.SelectedItem != null)
            {
                spotName = listBoxSpots.SelectedItem.ToString();
                spotID = 0;
                //search in SpotsList for this spotName and get the spotID assigned to it
                foreach (Spot s in spotList)
                {
                    if (s.spotName == spotName)
                    {
                        spotID = s.spotID;
                    }
                }
                //doublecheck, if the roomID has been found
                if (spotID != 0)
                {
                    MySpot myspot = new MySpot(spotID, spotName);
                    myspot.ShowDialog();
                }
            }
        }


        //MAIN BUTTONS

        // [ Add Spot ]
        private void buttonAddSpot_Click(object sender, EventArgs e)
        {

            MyRoom_AddSpot addSpot = new MyRoom_AddSpot(roomID, spotNamesList);
            addSpot.ShowDialog();

            //refresh listBoxSpots after AddSpot form is closed
            fillListBoxSpots();

        }

        // [ Edit Spot ]
        private void buttonEditSpot_Click(object sender, EventArgs e)
        {

            //check which spot to edit
            if (listBoxSpots.SelectedItem != null)
            {
                spotName = listBoxSpots.SelectedItem.ToString();
                spotID = 0;
                //search in SpotsList for this spotName and get the spotID assigned to it
                foreach (Spot s in spotList)
                {
                    if (s.spotName == spotName)
                    {
                        spotID = s.spotID;
                    }
                }
                //doublecheck, if the spotID has been found
                if (spotID != 0)
                {
                    MyRoom_EditSpot addSpot = new MyRoom_EditSpot(spotID, spotName, spotNamesList);
                    addSpot.ShowDialog();

                    //refresh listBoxSpots after EditSpot form is closed
                    fillListBoxSpots();
                }

            }
            else
            {
                MessageBox.Show("Please select the spot to EDIT from the list.");
            }

        }

        // [ Delete Spot ]
        private void buttonDeleteSpot_Click(object sender, EventArgs e)
        {
            //check which spot to delete
            if (listBoxSpots.SelectedItem != null)
            {
                string selectedSpotName = listBoxSpots.SelectedItem.ToString();

                //confirm user's intension to delete
                DialogResult deleteMessage = MessageBox.Show("Are you sure you want to delete the spot: \n" + selectedSpotName + " \nand all of its spots and plants?", "Delete: " + selectedSpotName, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (deleteMessage == DialogResult.OK)
                {
                    string selectedSpotNameDisplay = selectedSpotName;
                    //check if username contains special character: [']
                    if (selectedSpotName.Contains("'"))
                    {
                        selectedSpotName = selectedSpotName.Replace("'", "''");
                    }

                    //delete this entry from the DB
                    string queryDeletePrep = "DELETE FROM spots WHERE spotName = '" + selectedSpotName + "' AND roomIDFK = '" + roomID + "'";
                    string queryDelete = queryDeletePrep;
                    Query q = new Query(queryDelete);
                    if (q.success())
                    {
                        MessageBox.Show("Spot: " + selectedSpotNameDisplay + "\nhas been successfully deleted.");
                    }

                    //auto-refresh list of the spots
                    fillListBoxSpots();
                }

            }
            else
            {
                MessageBox.Show("Please select the spot to DELETE from the list.");
            }

        }

        // [ Go Back ]
        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        // [ Logout ]
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
        private void MyRoom_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
