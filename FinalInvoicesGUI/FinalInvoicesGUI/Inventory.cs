using System;
using System.Collections.Generic;
using System.Text;

namespace FinalInvoicesGUI
{
    class Inventory
    {
        protected int itemID;
        protected string itemName;
        protected double itemCost;
        public Inventory(int id, string name, double cost)
        {
            ItemID = id;
            ItemName = name;
            ItemCost = cost;
        }
        public int ItemID
        {
            get { return itemID; }
            set { itemID = value; }
        }
        public string ItemName
        {
            get { return itemName; }
            set { itemName = value; }
        }
        public double ItemCost
        {
            get { return itemCost; }
            set { itemCost = value; }
        }
    }
}
