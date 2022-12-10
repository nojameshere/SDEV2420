using System;
namespace Debug2420Final
{
    public class LineItem
    {
        protected int invoiceID, lineNumber, itemID, quantity;
        public LineItem(int invoiceID, int lineNumber, int itemID, int quantity)
        {
            this.invoiceID = invoiceID;
            this.lineNumber = lineNumber;
            this.itemID = itemID;
            this.quantity = quantity;
        }
        public int InvoiceID
        {
            get { return invoiceID; }
            set { invoiceID = value; }
        }
        public int LineNumber
        {
            get { return lineNumber; }
            set { lineNumber = value; }
        }
        public int ItemID
        {
            get { return itemID; }
            set { itemID = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
    }
}

