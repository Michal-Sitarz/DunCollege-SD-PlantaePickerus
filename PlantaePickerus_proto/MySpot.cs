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
    public partial class MySpot : Form
    {
        private string dbPath = @"C:\Users\Public\PlantaePickerus\PPdatabase.db";
        private int spotID;
        private List<Plant> plantList;
        private List<string> plantNamesList;

        public MySpot(int _spotID, string _spotName)
        {
            spotID = _spotID;
            InitializeComponent();
            fillListBoxPlants();

            labelSpotName.Text = _spotName;
        }

        //ListBox Plants

        public void fillListBoxPlants()
        {
            retrieveListOfPlants(); //this reads from DB

            //clear items
            listBoxPlants.DataSource = null;

            plantNamesList = new List<string>();
            //use plantNames from List of all entries from DB
            foreach (Plant p in plantList)
            {
                plantNamesList.Add(p.plantName);
            }

            //sort list alphabetically
            plantNamesList.Sort();

            //fill the listbox with list <of strings>
            listBoxPlants.DataSource = plantNamesList;

            //unselect any item (by default)
            listBoxPlants.ClearSelected();

        }

        // method to retrieve list of Plants from DB
        private void retrieveListOfPlants()
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
                    string selectQuery = "SELECT plantID, plantName, spotIDFK FROM plants WHERE spotIDFK = '" + spotID + "'";
                    using (SQLiteCommand command = new SQLiteCommand(selectQuery, dbCon))
                    {

                        using (SQLiteDataReader data = command.ExecuteReader())
                        {
                            try
                            {
                                //fill the data into List
                                plantList = new List<Plant>();
                                while (data.Read())
                                {
                                    // set values using: C# {set}
                                    Plant p = new Plant();
                                    p.plantID = Convert.ToInt32(data["plantID"]);
                                    p.plantName = (string)data["plantName"];
                                    plantList.Add(p);

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

        //listBoxPlants: double-click
        private void listBoxPlants_DoubleClick(object sender, EventArgs e)
        {
            //check if the item has been selected
            if (listBoxPlants.SelectedItem != null)
            {
                MessageBox.Show(listBoxPlants.SelectedItem.ToString());
            }
        }


        //MAIN BUTTONS

        // [ Add Plant ]
        private void buttonAddPlant_Click(object sender, EventArgs e)
        {
            
            MySpot_AddPlant addPlant = new MySpot_AddPlant(spotID, plantNamesList);
            addPlant.ShowDialog();

            //refresh listBoxPlants after AddPlant form is closed
            fillListBoxPlants();
            
        }
        
        // [ Delete Plant ]
        private void buttonDeletePlant_Click(object sender, EventArgs e)
        {
            //check which plant to delete
            if (listBoxPlants.SelectedItem != null)
            {
                string selectedPlantName = listBoxPlants.SelectedItem.ToString();

                //confirm user's intension to delete
                DialogResult deleteMessage = MessageBox.Show("Are you sure you want to delete the plant: \n" + selectedPlantName + " \nand all of its plants and plants?", "Delete: " + selectedPlantName, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (deleteMessage == DialogResult.OK)
                {
                    string selectedPlantNameDisplay = selectedPlantName;
                    //check if username contains special character: [']
                    if (selectedPlantName.Contains("'"))
                    {
                        selectedPlantName = selectedPlantName.Replace("'", "''");
                    }

                    //delete this entry from the DB
                    string queryDeletePrep = "DELETE FROM plants WHERE plantName = '" + selectedPlantName + "' AND spotIDFK = '" + spotID + "'";
                    string queryDelete = queryDeletePrep;
                    Query q = new Query(queryDelete);
                    if (q.success())
                    {
                        MessageBox.Show("Plant: " + selectedPlantNameDisplay + "\nhas been successfully deleted.");
                    }

                    //auto-refresh list of the plants
                    fillListBoxPlants();
                }

            }
            else
            {
                MessageBox.Show("Please select the plant to DELETE from the list.");
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
        private void MySpot_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
