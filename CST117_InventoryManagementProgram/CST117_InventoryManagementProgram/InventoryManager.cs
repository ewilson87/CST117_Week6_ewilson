/**
 * Program: Inventory Management Program
 * File: InventoryManager.cs
 * Summary: Multi form inventory management application - Milestone 3
 * Author: Evan Wilson
 * Date: May 20th, 2018
 **/

using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace CST117_InventoryManagementProgram
{
    class InventoryManager
    {
        List<InventoryItem> inventoryList = Program.inventoryList;
        private string header1 = "NAME,MODEL,TYPE,QUANTITY,MSRP,PRICE";
        private string header2 = ",,,,,";

        public void DeleteItem(InventoryItem inventoryItem)
        {
            inventoryList.Remove(inventoryItem);
            SaveInventoryFile();
        }

        public void AddItem(InventoryItem inventoryItem)
        {
            inventoryList.Add(inventoryItem);
            SaveInventoryFile();
        }

        public void UpdateItem(InventoryItem inventoryItem)
        {
            Program.savedChanges = true;
            Program.thisInventoryItem = inventoryItem;
            SaveInventoryFile();
        }

        public void SaveInventoryFile()
        {
            try
            {
                //saves file by overwriting existing file
                FileStream fcreate = File.Open("inventory.csv", FileMode.Create);

                StreamWriter streamWriter = new StreamWriter(fcreate);

                streamWriter.WriteLine(header1);

                foreach (InventoryItem inventoryItem in inventoryList)
                {
                    streamWriter.WriteLine();
                    streamWriter.Write(inventoryItem.Name + "," + inventoryItem.Model + "," + inventoryItem.Type + "," + inventoryItem.Quantity + ","
                                           + inventoryItem.Msrp + "," + inventoryItem.SalePrice);

                }

                streamWriter.Dispose();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }


        }

        public void saveBackup()
        {
            try
            {
                //creates a new backup file (overwrites previous backup) upon execution of program as a safeguard in case of accidental changes
                FileStream fcreate = File.Open("inventory BACK UP.csv", FileMode.Create);

                StreamWriter streamWriter = new StreamWriter(fcreate);

                streamWriter.WriteLine(header1);

                foreach (InventoryItem inventoryItem in inventoryList)
                {
                    streamWriter.WriteLine();
                    streamWriter.Write(inventoryItem.Name + "," + inventoryItem.Model + "," + inventoryItem.Type + "," + inventoryItem.Quantity + ","
                                       + inventoryItem.Msrp + "," + inventoryItem.SalePrice);

                }

                streamWriter.Dispose();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }


        }
    }
}
