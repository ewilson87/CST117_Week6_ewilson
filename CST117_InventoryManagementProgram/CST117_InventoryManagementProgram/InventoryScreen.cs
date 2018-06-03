/**
 * Program: Inventory Management Program
 * File: InventoryScreen.cs
 * Summary: Multi form inventory management application - Milestone 3
 * Author: Evan Wilson
 * Date: May 20th, 2018
 **/

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CST117_InventoryManagementProgram
{
    public partial class InventoryScreen : Form
    {
        List<InventoryItem> inventoryList = Program.inventoryList;
        InventoryManager inventoryManager = new InventoryManager();
        //stores selected row index for returning from individual item screen to properly update grid and list
        private int selectedRow;


        public InventoryScreen()
        {
            InitializeComponent();

            loadInventoryDataGrid();

            if (Program.savedChanges)
            {
                //checks bool for saved changes and updates accordingly
                updateItemInGrid();
                updateInventoryList();
                loadInventoryDataGrid();
            }
            //saves inventory file everytime this screen loads
            inventoryManager.SaveInventoryFile();
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

        private void viewButton_Click(object sender, EventArgs e)
        {
            IndividualProductScreen individualProductScreen = new IndividualProductScreen();

            //saves selected inventory item to Program.thisInventoryItem
            Program.thisInventoryItem = viewInventoryItem();

            this.Hide();
            individualProductScreen.Show();
        }

        private void inventoryDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();

            this.Hide();
            loginScreen.Show();
        }

        private InventoryItem viewInventoryItem()
        {
            InventoryItem inventoryItem = (InventoryItem)inventoryDataGrid.SelectedCells[6].Value;

            selectedRow = inventoryDataGrid.CurrentRow.Index;

            return inventoryItem;
        }

        private void loadInventoryDataGrid()
        {
            //sets all values in the data grid
            int row = 0;

            inventoryDataGrid.Rows.Clear();
            inventoryDataGrid.Refresh();

            foreach (InventoryItem inventoryItem in inventoryList)
            {
                inventoryDataGrid.Rows.Insert(row);
                inventoryDataGrid[0, row].Value = inventoryItem.Name;
                inventoryDataGrid[1, row].Value = inventoryItem.Model;
                inventoryDataGrid[2, row].Value = inventoryItem.Type;
                inventoryDataGrid[3, row].Value = inventoryItem.Quantity;
                inventoryDataGrid[4, row].Value = inventoryItem.Msrp;
                inventoryDataGrid[5, row].Value = inventoryItem.SalePrice;
                inventoryDataGrid[6, row].Value = inventoryItem;

                row++;
            }
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            NewItemScreen newItemScreen = new NewItemScreen();

            this.Hide();
            newItemScreen.Show();
        }

        private void updateItemInGrid()
        {
            //updates data grid based on item changed in individual item screen
            inventoryDataGrid[0, selectedRow].Value = Program.thisInventoryItem.Name;
            inventoryDataGrid[1, selectedRow].Value = Program.thisInventoryItem.Model;
            inventoryDataGrid[2, selectedRow].Value = Program.thisInventoryItem.Type;
            inventoryDataGrid[3, selectedRow].Value = Program.thisInventoryItem.Quantity;
            inventoryDataGrid[4, selectedRow].Value = Program.thisInventoryItem.Msrp;
            inventoryDataGrid[5, selectedRow].Value = Program.thisInventoryItem.SalePrice;
            inventoryDataGrid[6, selectedRow].Value = Program.thisInventoryItem;

            //defaults saved changes back to false after running method
            Program.savedChanges = false;
        }

        private void updateInventoryList()
        {
            //clears inventoryList and then re adds all items based on items from data grid
            Program.inventoryList.Clear();

            for (int row = 0; row < inventoryDataGrid.Rows.Count; row++)
            {
                //InventoryItem inventoryItem = new InventoryItem();

                //inventoryItem.Name = inventoryDataGrid[0, row].Value.ToString();
                //inventoryItem.Model = inventoryDataGrid[1, row].Value.ToString();
                //inventoryItem.Type = inventoryDataGrid[2, row].Value.ToString();
                //inventoryItem.Quantity = int.Parse(inventoryDataGrid[3, row].Value.ToString());
                //inventoryItem.Msrp = decimal.Parse(inventoryDataGrid[4, row].Value.ToString());
                //inventoryItem.SalePrice = decimal.Parse(inventoryDataGrid[5, row].Value.ToString());

                //uses InventoryItem that is saved in column 6 of data grid, unseen by user
                InventoryItem inventoryItem2 = (InventoryItem)inventoryDataGrid[6, row].Value;

                Program.inventoryList.Add(inventoryItem2);
            }
        }

        private void InventoryScreen_Load(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DeleteInventoryItem();
        }

        public void DeleteInventoryItem()
        {
            //confirm delete, then remove item from list, reload data grid and save the file
            if (MessageBox.Show("Confirm Delete? This action cannot be undone", "Delete Item",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                InventoryItem inventoryItem = (InventoryItem)inventoryDataGrid.SelectedCells[6].Value;

                inventoryList.Remove(inventoryItem);

                loadInventoryDataGrid();

                inventoryManager.SaveInventoryFile();
            }
        }
    }
}
