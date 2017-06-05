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
    public partial class MyRoom_EditSpot : Form
    {
        private string dbPath = @"C:\Users\Public\PlantaePickerus\PPdatabase.db";
        private int spotID;
        private List<string> spotNamesList;
        private string oldSpotName;
        private string newSpotName = "";
        private Spot t;

        public MyRoom_EditSpot(int _spotID, string _spotName, List<string> _spotNamesList)
        {
            InitializeComponent();
            spotNamesList = _spotNamesList;
            spotID = _spotID;

            textBoxSpotName.Text = oldSpotName = _spotName;

            //place cursor in the textBox (by default)
            textBoxSpotName.Select();

            //create a temporary single record for this form
            t = new Spot();
            retrieveSpotData();


            //fill comboBoxes with values to choose from
            // and set them to user values !!!

            //humidity
            List<string> humidityItems = new List<string>
            {"very dry","moderate dry","average","moderate humid","high humidity"};
            comboBoxHumidity.DataSource = humidityItems;
            string currentSpotHumidity = "";
            switch (t.spotHumidity)
            {
                case 0:
                    currentSpotHumidity = "very dry";
                    break;
                case 25:
                    currentSpotHumidity = "moderate dry";
                    break;
                case 50:
                    currentSpotHumidity = "average";
                    break;
                case 75:
                    currentSpotHumidity = "moderate humid";
                    break;
                case 100:
                    currentSpotHumidity = "high humidity";
                    break;
            }
            comboBoxHumidity.SelectedItem = currentSpotHumidity;

            //sunlight
            List<string> sunlightItems = new List<string>
            {"full sun","noon sun","afternoon sun","half shaded", "mostly shadow"};
            comboBoxSunlight.DataSource = sunlightItems;
            string currentSpotSunlight = "";
            switch (t.spotSunlight)
            {
                case 100:
                    currentSpotSunlight = "full sun";
                    break;
                case 85:
                    currentSpotSunlight = "noon sun";
                    break;
                case 70:
                    currentSpotSunlight = "afternoon sun";
                    break;
                case 50:
                    currentSpotSunlight = "half shaded";
                    break;
                case 30:
                    currentSpotSunlight = "mostly shadow";
                    break;
            }
            comboBoxSunlight.SelectedItem = currentSpotSunlight;

            //direction
            List<string> directionItems = new List<string>
            {"N","S","W","E","NE","NW","SE","SW"};
            comboBoxDirection.DataSource = directionItems;
            if (t.spotDirection == "NULL")
            {
                comboBoxDirection.SelectedIndex = -1;
            }
            else
            {
                comboBoxDirection.SelectedItem = t.spotDirection;
            }

            //cold drafts
            if (t.spotDrafts)
            {
                checkBoxColdDrafts.Checked = true;
            }
            else
            {
                checkBoxColdDrafts.Checked = false;
            }
        }

        /// GLOBAL methods

        // method to retrieve data (of the Spot to edit) from DB
        private void retrieveSpotData()
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
                    string selectQuery = "SELECT * FROM spots WHERE spotID = '" + spotID + "'";
                    using (SQLiteCommand command = new SQLiteCommand(selectQuery, dbCon))
                    {

                        using (SQLiteDataReader data = command.ExecuteReader())
                        {
                            try
                            {
                                //fill the data into record/class object
                                if (data.Read())
                                {
                                    // set values using: C# {set}
                                    t.spotID = Convert.ToInt32(data["spotID"]);
                                    t.spotName = (string)data["spotName"];
                                    t.spotSunlight = Convert.ToInt32(data["spotSunlight"]);
                                    t.spotHumidity = Convert.ToInt32(data["spotHumidity"]);
                                    t.spotDirection = (string)data["spotDirection"];
                                    t.spotDrafts = (bool)data["spotDrafts"];
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

        private void editSpotName()
        {
            //check if the user entered any name
            if (newSpotName == "")
            {
                MessageBox.Show("Please enter the name for the spot.");
            }

            else
            {
                //check if this name already exists (in user's spot list)
                bool foundSameSpotName = false;
                foreach (string r in spotNamesList)
                {
                    if (r == newSpotName)
                    {
                        //except current spot name, as this spot can keep the same name
                        if (newSpotName != oldSpotName)
                        {
                            foundSameSpotName = true;
                        }
                    }
                }

                if (foundSameSpotName == true)
                {
                    MessageBox.Show("You already have the spot with this name. \n\nHint: Try to add number index to the spot name, \nif you've got multiple similar spots.\nExample:''spot 1'',''spot 2''");
                }
                else
                {
                    //set values chosen by the user (use Spot record/class object to store the values)
                    Spot s = new Spot();

                    ///spotName
                    s.spotName = newSpotName;
                    //check if the spotName contains special character: [']
                    if (s.spotName.Contains("'"))
                    {
                        s.spotName = s.spotName.Replace("'", "''");
                    }

                    ///spotHumidity
                    switch (comboBoxHumidity.SelectedIndex)
                    {
                        case 0: // very dry
                            s.spotHumidity = 0;
                            break;
                        case 1: // moderate dry
                            s.spotHumidity = 25;
                            break;
                        case 2: // average
                            s.spotHumidity = 50;
                            break;
                        case 3: // moderate humid
                            s.spotHumidity = 75;
                            break;
                        case 4: // high humidity
                            s.spotHumidity = 100;
                            break;
                        default: // average
                            s.spotHumidity = 50;
                            break;
                    }

                    ///spotSunlight
                    switch (comboBoxSunlight.SelectedIndex)
                    {
                        case 0: // full sun
                            s.spotSunlight = 100;
                            break;
                        case 1: // noon sun
                            s.spotSunlight = 85;
                            break;
                        case 2: // afternoon sun
                            s.spotSunlight = 70;
                            break;
                        case 3: // half shaded
                            s.spotSunlight = 50;
                            break;
                        case 4: // mostly shadow
                            s.spotSunlight = 30;
                            break;
                        default: // half shaded
                            s.spotSunlight = 50;
                            break;
                    }

                    ///spotDirection
                    switch (comboBoxDirection.SelectedIndex)
                    {
                        case 0:
                            s.spotDirection = "N";
                            break;
                        case 1:
                            s.spotDirection = "S";
                            break;
                        case 2:
                            s.spotDirection = "W";
                            break;
                        case 3:
                            s.spotDirection = "E";
                            break;
                        case 4:
                            s.spotDirection = "NE";
                            break;
                        case 5:
                            s.spotDirection = "NW";
                            break;
                        case 6:
                            s.spotDirection = "SE";
                            break;
                        case 7:
                            s.spotDirection = "SW";
                            break;
                        default:
                            s.spotDirection = "NULL";
                            break;
                    }

                    ///coldDrafts
                    if (checkBoxColdDrafts.Checked)
                    {
                        s.spotDrafts = true;
                    }
                    else
                    {
                        s.spotDrafts = false;
                    }

                    // update spot in the database
                    string queryUpdate = "UPDATE spots SET spotName = '" + s.spotName + "', spotSunlight='" + s.spotSunlight + "', spotHumidity='" + s.spotHumidity + "', spotDirection='" + s.spotDirection + "', spotDrafts='" + s.spotDrafts + "' WHERE spotID = '" + spotID + "'";
                    Query q = new Query(queryUpdate);
                    if (q.success())
                    {
                        MessageBox.Show("Spot: " + newSpotName + "\nhas been UPDATED successfully.");
                        this.Hide();
                    }

                }

            }

        }

        /// events

        private void textBoxSpotName_TextChanged(object sender, EventArgs e)
        {
            newSpotName = textBoxSpotName.Text;
        }

        //button OK
        private void buttonOK_Click(object sender, EventArgs e)
        {
            editSpotName();
        }

        //press Enter (in the textBox)
        private void textBoxSpotName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                editSpotName();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void MyRoom_EditSpot_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }
    }
}
