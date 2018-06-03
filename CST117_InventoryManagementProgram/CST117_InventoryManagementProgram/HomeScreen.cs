/**
 * Program: Inventory Management Program
 * File: HomeScreen.cs
 * Summary: Multi form inventory management application - Milestone 3
 * Author: Evan Wilson
 * Date: May 20th, 2018
 **/

using System;
using System.Windows.Forms;

namespace CST117_InventoryManagementProgram
{
    public partial class HomeScreen : Form
    {
        InventoryScreen inventoryScreen = new InventoryScreen();
        SearchScreen searchScreen = new SearchScreen();
        NewItemScreen newItemScreen = new NewItemScreen();
        ReOrderScreen reOrderScreen = new ReOrderScreen();

        public HomeScreen()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            inventoryScreen.Show(this);
        }

        private void companyLabel_Click(object sender, EventArgs e)
        {

        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {

        }

        private void searchInventoryButton_Click(object sender, EventArgs e)
        {


            this.Hide();
            searchScreen.Show(this);
        }

        private void addNewItemButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            newItemScreen.Show(this);
        }

        private void reOrderInventoryButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            reOrderScreen.Show(this);
        }
    }
}
