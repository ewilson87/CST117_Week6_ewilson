/**
 * Program: Inventory Management Program
 * File: LoginScreen.cs
 * Summary: Multi form inventory management application - Milestone 3
 * Author: Evan Wilson
 * Date: May 20th, 2018
 **/

using System;
using System.Windows.Forms;

namespace CST117_InventoryManagementProgram
{
    public partial class LoginScreen : Form
    {
        private string username = "admin";
        private string password = "password";

        public LoginScreen()
        {
            InitializeComponent();

        }

        private void logonButton_Click(object sender, EventArgs e)
        {
            //generic username/password for entry
            if (usernameTextBox.Text == username && passwordTextBox.Text == password)
            {
                HomeScreen homeScreenForm = new HomeScreen();

                this.Hide();
                homeScreenForm.Show();
            }
            else MessageBox.Show("Wrong username or password entered");
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
