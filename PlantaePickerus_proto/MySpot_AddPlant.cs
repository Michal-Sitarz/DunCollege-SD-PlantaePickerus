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
    public partial class MySpot_AddPlant : Form
    {
        private int spotID;
        private List<string> plantNamesList;
        private string newPlantName = "";

        public MySpot_AddPlant(int _spotID, List<string> _plantNamesList)
        {
            InitializeComponent();
            plantNamesList = _plantNamesList;
            spotID = _spotID;

            //place cursor in the textBox (by default)
            textBoxPlantName.Select();

        }

        /// GLOBAL methods

        private void addPlantName()
        {
            //check if the user entered any name
            if (newPlantName == "")
            {
                MessageBox.Show("Please enter the name for the plant.");
            }

            else
            {
                //check if this name already exists (in user's plant list)
                bool foundSamePlantName = false;
                foreach (string r in plantNamesList)
                {
                    if (r == newPlantName)
                    {
                        foundSamePlantName = true;
                    }
                }

                if (foundSamePlantName == true)
                {
                    MessageBox.Show("You already have the plant with this name. \n\nHint: Try to add number index to the plant name, \nif you've got multiple similar plants.\nExample:''plant 1'',''plant 2''");
                }
                else
                {
                    string newPlantNameDisplay = newPlantName;

                    //check if the plantName contains special character: [']
                    if (newPlantName.Contains("'"))
                    {
                        newPlantName = newPlantName.Replace("'", "''");
                    }

                    // add plant to the database
                    string queryInsert = "INSERT INTO plants(plantID, plantName, spotIDFK) VALUES(NULL,'" + newPlantName + "','" + spotID + "')";
                    Query q = new Query(queryInsert);
                    if (q.success())
                    {
                        MessageBox.Show("Plant: " + newPlantNameDisplay + "\nhas been ADDED successfully.");
                        this.Hide();
                    }

                }

            }
        }

        /// events

        private void textBoxPlantName_TextChanged(object sender, EventArgs e)
        {
            newPlantName = textBoxPlantName.Text;
        }

        //button OK
        private void buttonOK_Click(object sender, EventArgs e)
        {
            addPlantName();
        }

        //press Enter (in the textBox)
        private void textBoxPlantName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addPlantName();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void MySpot_AddPlant_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }




    }
}
