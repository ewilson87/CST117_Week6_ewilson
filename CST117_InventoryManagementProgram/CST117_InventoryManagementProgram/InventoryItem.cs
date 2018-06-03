/**
 * Program: Inventory Management Program
 * File: InventoryItem.cs
 * Summary: Multi form inventory management application - Milestone 2
 * Author: Evan Wilson
 * Date: May 20th, 2018
 **/

namespace CST117_InventoryManagementProgram
{
    class InventoryItem
    {

        public InventoryItem()
        {

        }

        public InventoryItem(string name, string model, string type, int quantity, decimal msrp, decimal salePrice)
        {
            this.Name = name;
            this.Model = model;
            this.Type = type;
            this.Quantity = quantity;
            this.Msrp = msrp;
            this.SalePrice = salePrice;
        }

        public string Name { get; set; }

        public string Model { get; set; }

        public string Type { get; set; }

        public int Quantity { get; set; }

        public decimal Msrp { get; set; }

        public decimal SalePrice { get; set; }
    }
}
