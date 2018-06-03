/**
 * Program: Inventory Management Program
 * File: Program.cs
 * Summary: Multi form inventory management application - Milestone 3
 * Author: Evan Wilson
 * Date: May 20th, 2018
 **/

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CST117_InventoryManagementProgram
{
    static class Program
    {
        //static list to hold inventory throughout the entire application
        public static List<InventoryItem> inventoryList = new List<InventoryItem>();
        //static individual InventoryItem for use between passing to different forms
        public static InventoryItem thisInventoryItem;
        //static bool to acknowledge saved changes between forms
        public static bool savedChanges;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            //reads inventory file
            Inventory inventory = new Inventory();
            inventoryList = inventory.ReadInventoryFile();

            //saves a backup inventory file upon initial execution of application
            InventoryManager inventoryManager = new InventoryManager();
            inventoryManager.saveBackup();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginScreen());
        }
    }
}
