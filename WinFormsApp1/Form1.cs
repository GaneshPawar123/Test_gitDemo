using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        public void Load()
        {

        }
        Dictionary<string, List<string>> countryStateMap = new Dictionary<string, List<string>>()
        {
            { "Seating", new List<string> { "Chair", "Stool", "Recliner","Bar-Stool","Arm-Chair","Bench","Couch","Other" } },
            { "Sleeping", new List<string> { "Bed", "Sofa-Bed", "Todder-Bed", "Head-Board","Other" } },
            { "Entertairment", new List<string> { "Billiard Table", "Chase Board", "Home Bar","TV Unit", "Other" } },
            { "Sets", new List<string> { "Bed-Room", "Dining Set", "Vanity Set","Portable Set" } },
            { "Storage", new List<string> { "Bakers Rack", "Book Case", "Drawer" } },
            { "Tables", new List<string> { "Dining Table", "Folding Table", "Game Table", "Work Bench", "Wash Satnd", "Desk"} },
            { "Other", new List<string> { "Other" } }
        };

        Dictionary<string, List<string>> stateCityMap = new Dictionary<string, List<string>>()
        {
            { "Chair", new List<string> { "Wooden", "Bamboo", "plastic","Metal","Glass", "other" } },
            { "Stool", new List<string> { "Wooden", "Bamboo", "plastic", "Metal", "Glass", "other" } },
            { "Recliner", new List<string> { "Wooden", "Bamboo", "plastic", "Metal", "Glass", "other" } },
            { "Bar-Stool", new List<string> { "Wooden", "Bamboo", "plastic", "Metal", "Glass", "other" } },
            { "Arm-Chair", new List<string> { "Wooden", "Bamboo", "plastic", "Metal", "Glass", "other" } },
            { "bench", new List<string> { "Wooden", "Bamboo", "plastic", "Metal", "Glass", "other" } },
            { "Couch", new List<string> { "Wooden", "Bamboo", "plastic", "Metal", "Glass", "other" } },
            { "Other", new List<string> { "Wooden", "Bamboo", "plastic", "Metal", "Glass", "Other" } },
            { "Bed", new List<string> { "Wooden", "Bamboo", "Metal", "other" } },
            { "Sofa-Bed", new List<string> { "Wooden", "Bamboo",  "Metal", "other" } },
            { "Todder-Bed", new List<string> { "Wooden", "Bamboo", "plastic", "Metal", "Glass", "other" } },
            { "Head-Board", new List<string> { "Wooden", "Bamboo", "plastic", "Metal", "Glass", "other" } },
            { "Billiard Table", new List<string> { "Wooden", "Bamboo", "plastic", "Metal", "Glass", "other" } },
            { "Chase Board", new List<string> { "Wooden", "plastic","Glass", "other" } },
            { "Home Bar", new List<string> { "Wooden", "plastic", "Metal",  "other" } },
            { "TV Unit", new List<string> { "Wooden",   "Metal",  "other" } },
            { "Bed-Room", new List<string> { "Wooden", "Bamboo", "plastic", "Metal", "Glass", "other" } },
            { "Dining Set", new List<string> { "Wooden",  "plastic", "Metal", "Glass","Tiles", "other" } },
            { "Vanity Set", new List<string> { "Wooden", "Bamboo", "plastic", "Metal", "Glass", "other" } },
            { "Portable Set", new List<string> { "Wooden", "Bamboo", "plastic", "Metal", "Glass", "other" } },
            { "Bakers Rack", new List<string> { "Wooden", "Bamboo", "plastic", "Metal", "Glass", "other" } },
            { "Book Case", new List<string> { "Wooden", "Bamboo", "plastic", "Metal", "Glass", "Tiles","other" } },
            { "Drawer", new List<string> { "Wooden",  "Metal", "Glass", "other" } },
            { "Dining Table", new List<string> { "Wooden", "Bamboo", "plastic", "Metal", "Glass", "other" } },
            { "Game Table", new List<string> { "Wooden", "Bamboo", "plastic", "Metal","Glass", "other" } },
            { "Folding Table", new List<string> { "Wooden", "Bamboo", "plastic", "Metal", "other" } },
            { "Work Bench", new List<string> { "Wooden", "Bamboo", "plastic", "Metal", "other" } },
            { "Wash Satnd", new List<string> { "Tiles", "Glass", "plastic", "Metal", "other" } },
            { "Desk", new List<string> { "Wooden", "plastic", "Metal", "other" } },
        };

        public Form1()
        {
            InitializeComponent();
            foreach (string country in countryStateMap.Keys)
            {
                comboBoxCountry.Items.Add(country);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clear the state and city ComboBoxes
            comboBoxState.Items.Clear();
            comboBoxCity.Items.Clear();

            // Get the selected country
            string selectedCountry = comboBoxCountry.SelectedItem.ToString();

            // Populate the state ComboBox based on the selected country
            if (countryStateMap.ContainsKey(selectedCountry))
            {
                foreach (string state in countryStateMap[selectedCountry])
                {
                    comboBoxState.Items.Add(state);
                }
            }
        }

        private void comboBoxState_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxCity.Items.Clear();

            // Get the selected state
            string selectedState = comboBoxState.SelectedItem.ToString();

            // Populate the city ComboBox based on the selected state
            if (stateCityMap.ContainsKey(selectedState))
            {
                foreach (string city in stateCityMap[selectedState])
                {
                    comboBoxCity.Items.Add(city);
                }
            }
        }
    }
}