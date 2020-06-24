using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KomisSamochodowy
{
    public partial class Form : System.Windows.Forms.Form
    {
        BindingList<Car> entries = new BindingList<Car>();
        BindingList<Car> searchList = new BindingList<Car>();
        static int indexEdited = -1;
        public Form()
        {
            InitializeComponent();
        }
        static int index = 0; 

        private void Form_Load(object sender, EventArgs e)
        {
            setupDataGridView(sender, e);
            displayRows();
            typeBox.SelectedIndex = 0;
        }

        private void setupDataGridView(object sender, EventArgs e)
        {
            this.entryView.AutoGenerateColumns = false;
            this.entryView.EditMode = DataGridViewEditMode.EditProgrammatically;

            List<String> property = new List<string>{ "id", "brand", "model", "year", "properties", "edit", "delete" };
            List<String> header = new List<string> { "ID", "Brand", "Model", "Year", "Properties", "Edit", "Delete" };

            for(int i = 0; i < property.Count(); ++i)
            {
                DataGridViewColumn col;
                if (i < 4)
                {
                    col = new DataGridViewTextBoxColumn();
                    col.Width = 125;
                }
                else
                {
                    col = new DataGridViewButtonColumn()
                    {
                        Text = header[i],
                        Width = 85,
                        UseColumnTextForButtonValue = true
                    };
                }
                col.HeaderText = header[i];
                col.DataPropertyName = property[i];
                col.Name = property[i];
                this.entryView.Columns.Add(col);
            }
        }


        private void yearBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(yearBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                yearBox.Text = yearBox.Text.Remove(yearBox.Text.Length - 1);
            }
        }

        private void addEntry_Click(object sender, EventArgs e)
        {
            if (brandBox.Text != "" && modelBox.Text != "" && yearBox.Text != "")
            {

                switch (typeBox.SelectedIndex)
                {
                    case -1:
                        {
                            MessageBox.Show("Type not selected.");
                            break;
                        }
                    case 0:
                        {
                            int seats = 0;
                            if (Int32.TryParse(additionalBox.Text, out seats))
                            {
                                FamilyCar tmp = new FamilyCar(index, brandBox.Text, modelBox.Text, yearBox.Text, seats);
                                entries.Add(tmp);
                                index++;
                            }
                            else
                            {
                                MessageBox.Show("Invalid number of seats.", "Number of seats in vehicle.");
                            }
                            break;
                        }
                    case 1:
                        {
                            OffroadCar tmp = new OffroadCar(index, brandBox.Text, modelBox.Text, yearBox.Text, additionalCheckbox.Checked);
                            entries.Add(tmp);
                            index++;
                            break;
                        }
                }
            }
        }

        private void displayRows()
        {
            this.entryView.DataSource = entries;
        }

        private void typeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            typeSelector(typeBox.SelectedIndex);
        }

        private void typeSelector(int selected)
        {
            switch (selected)
            {
                case 0: //family
                    {
                        typeBox.SelectedIndex = 0;
                        additionalCheckbox.Enabled = false;
                        additionalBox.Enabled = true;
                        additionalLabel.Text = "Seats amount: ";

                        break;
                    }
                case 1: //offroad
                    {
                        typeBox.SelectedIndex = 1;
                        additionalCheckbox.Enabled = true;
                        additionalBox.Enabled = false;
                        additionalLabel.Text = "Has differential lock: ";

                        break;
                    }
            }
        }

        private void entryView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                try
                {
                    if (e.ColumnIndex == 4)//properties
                    {
                        if(searchButton.Enabled)
                        {
                            displayProperties(e.RowIndex, entries);
                        }else
                        {
                            displayProperties(e.RowIndex, searchList);
                        }
                    }
                    else if(e.ColumnIndex == 5)//edit
                    {
                        int carType = convertStringToType(entries[e.RowIndex].ToString());
                        typeSelector(carType);
                        indexEdited = e.RowIndex;
                        editionInPlace(true, carType);

                    }
                    else if(e.ColumnIndex == 6 && saveButton.Enabled == false)//delete
                    {
                        entries.RemoveAt(e.RowIndex);
                    }
                }
                catch (NullReferenceException)
                {
                }

            }
        }

        private void editionInPlace(bool setEdition, int carType)
        {
            addEntry.Enabled = !setEdition;
            typeBox.Enabled = !setEdition;
            searchButton.Enabled = !setEdition;
            saveButton.Enabled = setEdition;

            if(setEdition)
            {
                brandBox.Text = entries[indexEdited].brand;
                modelBox.Text = entries[indexEdited].model;
                yearBox.Text = entries[indexEdited].year;

                switch (carType)
                {
                    case 0:
                        {
                            FamilyCar tmp = (FamilyCar)entries[indexEdited];
                            additionalBox.Text = tmp.seatsValue.ToString();
                            break;
                        }
                    case 1:
                        {
                            OffroadCar tmp = (OffroadCar)entries[indexEdited];
                            additionalCheckbox.Checked = tmp.hasDifflock;
                            break;
                        }
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            int carType = typeBox.SelectedIndex;

            switch (carType)
            {
                case 0:
                    {

                        int seats = 0;
                        if (Int32.TryParse(additionalBox.Text, out seats))
                        {
                            FamilyCar tmp = new FamilyCar(entries[indexEdited].id, brandBox.Text, modelBox.Text, yearBox.Text, seats);
                            entries[indexEdited] = tmp;
                            indexEdited = -1;
                            editionInPlace(false, indexEdited);
                            break;
                        }
                        else
                        {
                            MessageBox.Show("Invalid number of seats.", "Number of seats in vehicle.");
                        }
                        break;
                    }
                case 1:
                    {
                        OffroadCar tmp = new OffroadCar(entries[indexEdited].id, brandBox.Text, modelBox.Text, yearBox.Text, additionalCheckbox.Checked);
                        entries[indexEdited] = tmp;
                        indexEdited = -1;
                        editionInPlace(false, indexEdited);
                        break;
                    }
            }
        }

        private int convertStringToType(string type)
        {
            type = type.Split('.')[1];
            switch(type)
            {
                case "FamilyCar":
                    {
                        return 0;
                    }
                case "OffroadCar":
                    {
                        return 1;
                    }
            }
            return 2;
        }

        private string convertIntToType(int type)
        {
            switch (type)
            {
                case 0:
                    {
                        return "Family";
                    }
                case 1:
                    {
                        return "Offroad";
                    }
            }
            return "Unknown";
        }
        private void displayProperties(int index, BindingList<Car> bindingList)
        {
            int carTypeInt = convertStringToType(bindingList[index].ToString());
            string carTypeString = convertIntToType(carTypeInt);
            String properties;
            
            switch (carTypeInt)
            {
                case 0:
                    {
                        FamilyCar tmp = (FamilyCar)bindingList[index];
                        properties = "Type of vehicle: " + carTypeString 
                            + "\nID: " + bindingList[index].id 
                            + "\nBrand: " + bindingList[index].brand 
                            + "\nModel: " + bindingList[index].model 
                            + "\nYear: " + bindingList[index].year 
                            + "\nSeats amount: " + tmp.seatsValue;


                        MessageBox.Show(properties, "Properties of car.");
                        break;
                    }
                case 1:
                    {
                        OffroadCar tmp = (OffroadCar)bindingList[index];
                        properties = "Type of vehicle: " 
                            + carTypeString + "\nID: " 
                            + bindingList[index].id + "\nBrand: " 
                            + bindingList[index].brand + "\nModel: " 
                            + bindingList[index].model + "\nYear: " 
                            + bindingList[index].year + "\nHas differential lock: " 
                            + tmp.hasDifflock;

                        MessageBox.Show(properties, "Properties of car.");
                        break;
                    }
            }

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string search = searchBox.Text;
            bool found;
            searchInPlace(true);

            foreach (Car entry in entries)
            {
                found = false;
                int carType = convertStringToType(entry.ToString());

                if (String.Equals(search, entry.id.ToString(), StringComparison.OrdinalIgnoreCase))
                {
                    found = true;
                }
                if (String.Equals(search, entry.brand.ToString(), StringComparison.OrdinalIgnoreCase))
                {
                    found = true;
                }
                if (String.Equals(search, entry.model.ToString(), StringComparison.OrdinalIgnoreCase))
                {
                    found = true;
                }
                if (String.Equals(search, entry.year.ToString(), StringComparison.OrdinalIgnoreCase))
                {
                    found = true;
                }

                switch (carType)
                {
                    case 0:
                        {
                            FamilyCar tmp = (FamilyCar)entry;
                            if(String.Equals(search, tmp.seatsValue.ToString(), StringComparison.OrdinalIgnoreCase))
                            {
                                found = true;
                            }
                            break;
                        }
                    case 1:
                        {
                            OffroadCar tmp = (OffroadCar)entry;
                            if (String.Equals(search, tmp.hasDifflock.ToString(), StringComparison.OrdinalIgnoreCase))
                            {
                                found = true;
                            };
                            break;
                        }
                }
                if(found)
                {
                    searchList.Add(entry);
                }
            }
        }


        private void searchInPlace(bool search)
        {
            entryView.Columns[5].Visible = !search;
            entryView.Columns[6].Visible = !search;
            searchButton.Enabled = !search;
            clearButton.Enabled = search;

            if (search)
            {
                this.entryView.DataSource = searchList;
            }
            else
            {
                this.entryView.DataSource = entries;
                searchList.Clear();
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            searchInPlace(false);
        }
    }
}

