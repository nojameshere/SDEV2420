using System;
using System.Collections.Generic;
using System.Text;

namespace FinalInvoicesGUI
{
    class Invoice
    {
        protected int invoiceID, customerID;
        protected Date invoiceDate;
        public Invoice(int invoiceID, int customerID, int month, int day, int year)
        {
            InvoiceID = invoiceID;
            CustomerID = customerID;
            invoiceDate = new Date(year, month, day);
        }
        public int InvoiceID
        {
            get { return invoiceID; }
            set { invoiceID = value; }
        }
        public int CustomerID
        {
            get { return customerID; }
            set { customerID = value; }
        }
        public Date InvoiceDate
        {
            get { return invoiceDate; }
        }
    }
}
