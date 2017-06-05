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
    public partial class MyRoom_AddSpot : Form
    {
        private int roomID;
        private List<string> spotNamesList;
        private string newSpotName = "";

        public MyRoom_AddSpot(int _roomID, List<string> _spotNamesList)
        {
            InitializeComponent();
            spotNamesList = _spotNamesList;
            roomID = _roomID;

            //place cursor in the textBox (by default)
            textBoxSpotName.Select();

            //fill comboBoxes with values to choose from
            //humidity
            List<string> humidityItems = new List<string>
            {"very dry","moderate dry","average","moderate humid","high humidity"};
            comboBoxHumidity.DataSource = humidityItems;
            comboBoxHumidity.SelectedItem = "average";

            //sunlight
            List<string> sunlightItems = new List<string>
            {"full sun","noon sun","afternoon sun","half shaded", "mostly shadow"};
            comboBoxSunlight.DataSource = sunlightItems;
            comboBoxSunlight.SelectedItem = "half shaded";

            //direction
            List<string> directionItems = new List<string>
            {"N","S","W","E","NE","NW","SE","SW"};
            comboBoxDirection.DataSource = directionItems;
            comboBoxDirection.SelectedIndex = -1;

        }

        /// GLOBAL methods

        private void addSpotName()
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
                        foundSameSpotName = true;
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
                    
                    //MessageBox.Show(s.spotName+"\n"+s.spotSunlight + "\n" +s.spotHumidity + "\n" +s.spotDirection + "\n" +s.spotDrafts);
                    
                    // add spot to the database
                    string queryInsert = "INSERT INTO spots(spotID, spotName , spotSunlight, spotHumidity, spotDirection, spotDrafts, roomIDFK) VALUES(NULL,'" + s.spotName + "','" + s.spotSunlight + "','" + s.spotHumidity + "','" + s.spotDirection + "','" + s.spotDrafts + "','" + roomID + "')";

                    Query q = new Query(queryInsert);
                    if (q.success())
                    {
                        MessageBox.Show("Spot: " + newSpotName + "\nhas been ADDED successfully.");
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
            addSpotName();
        }

        //press Enter (in the textBox)
        private void textBoxSpotName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addSpotName();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void MyRoom_AddSpot_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }
    }
}
