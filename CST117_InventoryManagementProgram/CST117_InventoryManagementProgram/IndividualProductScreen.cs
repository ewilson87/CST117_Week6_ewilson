/**
 * Program: Inventory Management Program
 * File: IndividualProductScreen.cs
 * Summary: Multi form inventory management application - Milestone 3
 * Author: Evan Wilson
 * Date: May 20th, 2018
 **/

using System;
using System.Windows.Forms;

namespace CST117_InventoryManagementProgram
{
    public partial class IndividualProductScreen : Form
    {

        public IndividualProductScreen()
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

        private void IndividualProductScreen_Load(object sender, EventArgs e)
        {
            //loads values for current selected item
            nameTextBox.Text = Program.thisInventoryItem.Name;
            modelTextBox.Text = Program.thisInventoryItem.Model;
            typeTextBox.Text = Program.thisInventoryItem.Type;
            quantityUpDown.Value = Program.thisInventoryItem.Quantity;
            msrpUpDown.Value = Program.thisInventoryItem.Msrp;
            priceUpDown.Value = Program.thisInventoryItem.SalePrice;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            //enables user to edit items
            nameTextBox.ReadOnly = false;
            priceUpDown.ReadOnly = false;
            quantityUpDown.ReadOnly = false;
            typeTextBox.ReadOnly = false;
            msrpUpDown.ReadOnly = false;
            modelTextBox.ReadOnly = false;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            //cancels any changes done prior to a save and resets textboxes
            nameTextBox.ReadOnly = true;
            priceUpDown.ReadOnly = true;
            quantityUpDown.ReadOnly = true;
            typeTextBox.ReadOnly = true;
            msrpUpDown.ReadOnly = true;
            modelTextBox.ReadOnly = true;

            nameTextBox.Text = Program.thisInventoryItem.Name;
            modelTextBox.Text = Program.thisInventoryItem.Model;
            typeTextBox.Text = Program.thisInventoryItem.Type;
            quantityUpDown.Value = Program.thisInventoryItem.Quantity;
            msrpUpDown.Value = Program.thisInventoryItem.Msrp;
            priceUpDown.Value = Program.thisInventoryItem.SalePrice;
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();

            this.Hide();
            loginScreen.Show();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            InventoryScreen inventoryScreen = new InventoryScreen();

            this.Hide();
            inventoryScreen.Show();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            confirmChanges();
        }

        private void confirmChanges()
        {
            //confirm box for changes. Sets program wide savedChanges bool to true so InventoryScreen knows to look for changes and update as necessary
            if (MessageBox.Show("Confirm changes?", "Edit item",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Program.savedChanges = true;

                InventoryItem inventoryItem = new InventoryItem();

                inventoryItem.Name = nameTextBox.Text;
                inventoryItem.Model = modelTextBox.Text;
                inventoryItem.Type = typeTextBox.Text;
                inventoryItem.Quantity = (int)quantityUpDown.Value;
                inventoryItem.Msrp = msrpUpDown.Value;
                inventoryItem.SalePrice = priceUpDown.Value;

                Program.thisInventoryItem = inventoryItem;

                //inventoryManager.SaveInventoryFile();
                backButton.PerformClick();

            }

        }
    }
}
