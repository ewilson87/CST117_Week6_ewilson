/**
 * Program: Inventory Management Program
 * File: SearchScreen.cs
 * Summary: Multi form inventory management application - Milestone 3
 * Author: Evan Wilson
 * Date: May 20th, 2018
 **/

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CST117_InventoryManagementProgram
{

    public partial class SearchScreen : Form
    {

        List<InventoryItem> searchList = new List<InventoryItem>();
        private static string searchString;

        public SearchScreen()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            HomeScreen homeScreen = new HomeScreen();

            this.Close();
            homeScreen.Show();
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            IndividualProductScreen individualProductScreen = new IndividualProductScreen();

            this.Hide();
            individualProductScreen.Show();
        }

        private void quantityRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SearchScreen_Load(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            searchList.Clear();
            Search();
        }

        private void Search()
        {
            //converts search to upper case to match any values in current inventory
            searchString = searchTextBox.Text.ToUpper();

            //clears and refreshed current search data grid
            searchDataGrid.Rows.Clear();
            searchDataGrid.Refresh();
            int row = 0;

            //uses FindAll method in LINQ using search method as criteria on what to look for and which radio button was selected
            searchList = Program.inventoryList.FindAll(Search);
            //if list has at least one value, display it, otherways mbox 
            if (searchList.Count != 0)
            {
                foreach (InventoryItem item in searchList)
                {
                    searchDataGrid.Rows.Insert(row);
                    searchDataGrid[0, row].Value = item.Name;
                    searchDataGrid[1, row].Value = item.Model;
                    searchDataGrid[2, row].Value = item.Type;
                    searchDataGrid[3, row].Value = item.Quantity;
                    searchDataGrid[4, row].Value = item.Msrp;
                    searchDataGrid[5, row].Value = item.SalePrice;
                    searchDataGrid[6, row].Value = item;

                    row++;
                }
            }
            else MessageBox.Show("NO RESULTS FOUND");
        }

        private void searchGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private bool Search(InventoryItem item)
        {
            if (nameRadioButton.Checked)
            {
                if (item.Name.Contains(searchString))
                {
                    return true;
                }
                return false;
            }
            else if (modelRadioButton.Checked)
            {
                if (item.Model.Contains(searchString))
                {
                    return true;
                }
                return false;
            }
            else if (typeRadioButton.Checked)
            {
                if (item.Type.Contains(searchString))
                {
                    return true;
                }
                return false;
            }
            else if (quantityRadioButton.Checked)
            {
                try
                {
                    if (item.Quantity <= int.Parse(searchString))
                    {
                        return true;
                    }
                    return false;
                }
                catch
                {
                }
            }
            else if (msrpRadioButton.Checked)
            {
                try
                {
                    if (item.Msrp <= decimal.Parse(searchString))
                    {
                        return true;
                    }
                    return false;
                }
                catch
                {
                }
            }
            else if (priceRadioButton.Checked)
            {
                try
                {
                    if (item.SalePrice <= decimal.Parse(searchString))
                    {
                        return true;
                    }
                    return false;
                }
                catch
                {
                }
            }
            return false;
        }
    }
}
