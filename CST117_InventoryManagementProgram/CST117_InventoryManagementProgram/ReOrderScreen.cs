/**
 * Program: Inventory Management Program
 * File: ReOrderScreen.cs
 * Summary: Multi form inventory management application - Milestone 3
 * Author: Evan Wilson
 * Date: May 20th, 2018
 **/

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CST117_InventoryManagementProgram
{
    public partial class ReOrderScreen : Form
    {
        List<InventoryItem> lowInventoryItems = new List<InventoryItem>();
        List<InventoryItem> orderItems = new List<InventoryItem>();

        public ReOrderScreen()
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

            this.Hide();
            homeScreen.Show();
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ReOrderScreen_Load(object sender, EventArgs e)
        {

        }

        private void fillLowInventoryGrid()
        {
            //clears list and refreshes data grid before searching
            lowInventoryItems.Clear();
            lowInventoryDataGrid.Rows.Clear();
            lowInventoryDataGrid.Refresh();
            int row = 0;

            //searches inventoryList for any item with quantity less than selected value on quantity slider and adds to a lowInventoryItems list
            foreach (InventoryItem item in Program.inventoryList)
            {
                if (item.Quantity <= quantitySlider.Value)
                {
                    lowInventoryItems.Add(item);
                }
            }

            //loads low inventory item list into data grid
            foreach (InventoryItem lowInventoryItem in lowInventoryItems)
            {
                lowInventoryDataGrid.Rows.Insert(row);
                lowInventoryDataGrid[0, row].Value = lowInventoryItem.Name;
                lowInventoryDataGrid[1, row].Value = lowInventoryItem.Model;
                lowInventoryDataGrid[2, row].Value = lowInventoryItem.Type;
                lowInventoryDataGrid[3, row].Value = lowInventoryItem.Quantity;
                lowInventoryDataGrid[4, row].Value = lowInventoryItem.Msrp;
                lowInventoryDataGrid[5, row].Value = lowInventoryItem.SalePrice;
                lowInventoryDataGrid[6, row].Value = lowInventoryItem;

                row++;
            }

        }

        private void addToOrderGrid()
        {
            //adds item to order grid. Need to add additional way to maybe limit putting same object in twice, or setting how many to order...
            try
            {
                orderItems.Add((InventoryItem)lowInventoryDataGrid.SelectedCells[6].Value);
                refreshOrderGrid();
            }
            catch
            {
            }
        }

        private void bunifuSlider1_ValueChanged(object sender, EventArgs e)
        {
            itemQuantityLabel.Text = quantitySlider.Value.ToString();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            addToOrderGrid();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            //removes item from order list
            try
            {
                orderItems.Remove((InventoryItem)orderDataGrid.SelectedCells[6].Value);
                orderDataGrid.Rows.Remove(orderDataGrid.CurrentRow);
            }
            catch
            {
            }
        }

        private void refreshOrderGrid()
        {
            //refreshed the order data grid
            orderDataGrid.Rows.Clear();
            orderDataGrid.Refresh();

            int row = 0;

            foreach (InventoryItem item in orderItems)
            {
                orderDataGrid.Rows.Insert(row);
                orderDataGrid[0, row].Value = orderItems[row].Name;
                orderDataGrid[1, row].Value = orderItems[row].Model;
                orderDataGrid[2, row].Value = orderItems[row].Type;
                orderDataGrid[3, row].Value = orderItems[row].Quantity;
                orderDataGrid[4, row].Value = orderItems[row].Msrp;
                orderDataGrid[5, row].Value = orderItems[row].SalePrice;
                orderDataGrid[6, row].Value = orderItems[row];

                row++;
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            fillLowInventoryGrid();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();

            this.Hide();
            loginScreen.Show();
        }
    }
}
