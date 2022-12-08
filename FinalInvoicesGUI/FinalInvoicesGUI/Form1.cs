using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalInvoicesGUI
{
    public partial class Form1 : Form
    {
        Inventory[] inventory = 
        {
            new Inventory(1234, "blue ink pen", 1.19),
            new Inventory(1235, "black ink pen", 1.19),
            new Inventory(1236, "red ink pen", 1.19),
            new Inventory(2134, "blue pencil", .79),
            new Inventory(2135, "black pencil", .79),
            new Inventory(2136, "red pencil", .79),
            new Inventory(3124, "large eraser", 2.59),
            new Inventory(3125, "medium eraser", 1.59),
            new Inventory(3126, "cap eraser", .89),
            new Inventory(6233, "clear pushpins", 7.50),
            new Inventory(6234, "white pushpins", 7.50),
            new Inventory(6235, "green pushpins", 7.50),
            new Inventory(6236, "red pushpins", 7.50),
            new Inventory(6237, "blue pushpins", 7.50),
            new Inventory(6238, "yellow pushpins", 7.50),
            new Inventory(6239, "mixed pushpins", 7.50),
            new Inventory(5671, "small stapler", 4.25),
            new Inventory(5789, "stand stapler", 4.50),
            new Inventory(5312, "small staples", 1.25),
            new Inventory(5313, "large staples", 3.75)
        };
        Customer[] customers = 
        {
            new Customer(876, "Mary", "Johnson"),
            new Customer(490, "Larry", "Brooks"),
            new Customer(552, "Ann", "Masters"),
            new Customer(923, "Frank", "Jones"),
            new Customer(259, "Gary", "Martin")
        };
        Invoice[] invoices = 
        {
            new Invoice(22, 876, 5, 2, 2019),
            new Invoice(25, 876, 5, 3, 2019),
            new Invoice(26, 259, 5, 4, 2019),
            new Invoice(27, 490, 2, 28, 2018),
            new Invoice(28, 923, 3, 15, 2018),
            new Invoice(30, 552, 8, 10, 2018)
        };
        LineItem[] lineItems = {
            new LineItem(22, 1, 1234, 5),
            new LineItem(22, 2, 1235, 5),
            new LineItem(22, 3, 1236, 5),
            new LineItem(22, 4, 6233, 5),
            new LineItem(22, 5, 6239, 5),
            new LineItem(25, 1, 5671, 1),
            new LineItem(25, 2, 5312, 2),
            new LineItem(25, 3, 2135, 2),
            new LineItem(25, 4, 6239, 2),
            new LineItem(30, 1, 2135, 10),
            new LineItem(30, 2, 2136, 10),
            new LineItem(30, 3, 1234, 10),
            new LineItem(30, 4, 1235, 10),
            new LineItem(30, 5, 6239, 10),
            new LineItem(26, 1, 5789, 5),
            new LineItem(26, 2, 5671, 3),
            new LineItem(26, 3, 5312, 5),
            new LineItem(26, 4, 5313, 2),
            new LineItem(26, 5, 6239, 2),
            new LineItem(27, 1, 3124, 4),
            new LineItem(27, 2, 3125, 4),
            new LineItem(27, 3, 2135, 4),
            new LineItem(27, 4, 6239, 4),
            new LineItem(28, 1, 6234, 4),
            new LineItem(28, 2, 6235, 4),
            new LineItem(28, 3, 6236, 4),
            new LineItem(28, 4, 6237, 4),
            new LineItem(28, 5, 6239, 4),
            new LineItem(28, 6, 6238, 4)};
        public Form1()
        {
            InitializeComponent();
        }

        private void byLastNameRadial_CheckedChanged(object sender, EventArgs e)
        {
            //Display customers by last name
            leftBox.Clear();
            var byLast = from customer in customers
                         orderby customer.Last
                         select customer;
            foreach (var customer in byLast)
            {
                leftBox.Text += $"{customer.CustomerID}\t{customer.Last}, {customer.First}\n";
            }
        }

        private void byCustomerIDRadial_CheckedChanged(object sender, EventArgs e)
        {
            //Display by customer id
            leftBox.Clear();
            var byID = from customer in customers
                       orderby customer.CustomerID
                       select customer;
            foreach (var customer in byID)
            {
                leftBox.Text += $"{customer.CustomerID}\t{customer.Name}\n";
            }
        }

        private void byInvIDRadial_CheckedChanged(object sender, EventArgs e)
        {
            //List inventory items sorted by ID
            leftBox.Clear();
            var byInvID = from item in inventory
                          orderby item.ItemID
                          select item;
            foreach (var item in byInvID)
            {
                leftBox.Text += $"{item.ItemID}\t{item.ItemName}\t{item.ItemCost:C2}\n";
            }
        }

        private void byCostRadial_CheckedChanged(object sender, EventArgs e)
        {
            //List inventory items sorted by cost
            leftBox.Clear();
            var byInvCost = from item in inventory
                            orderby item.ItemCost
                            select item;
            foreach (var item in byInvCost)
            {
                leftBox.Text += $"{item.ItemCost:C2}\t{item.ItemID}\t{item.ItemName}\n";
            }
        }

        private void invoicesRadial_CheckedChanged(object sender, EventArgs e)
        {
            //Display invoices by invoiceID, list the line items and the customer associated with them
            rightBox.Clear();
            rightBox.Text += "Invoices\n\n";
            var combineLineItemsANDInventory = from li in lineItems
                                               join items in inventory on li.ItemID equals items.ItemID
                                               orderby li.LineNumber
                                               select new
                                               {
                                                   LineNumber = li.LineNumber,
                                                   ItemName = items.ItemName,
                                                   ItemCost = items.ItemCost,
                                                   QuantitySold = li.Quantity,
                                                   Cost = li.Quantity * items.ItemCost,
                                                   InvoiceID = li.InvoiceID
                                               };
            var combineCustomerANDInvoice = from invoice in invoices
                                            join customer in customers on invoice.CustomerID equals customer.CustomerID
                                            orderby invoice.InvoiceID
                                            select new
                                            {
                                                InvoiceID = invoice.InvoiceID,
                                                CustomerID = customer.CustomerID,
                                                CustomerName = customer.Name,
                                                InvoiceDate = invoice.InvoiceDate
                                            };
            var groupJoinTheFirst = from invoice in combineCustomerANDInvoice
                                    join item in combineLineItemsANDInventory on invoice.InvoiceID equals item.InvoiceID
                                    select invoice;
            foreach (var thing in groupJoinTheFirst)
            {
                var total = 0;
                rightBox.Text += $"Invoice {thing.InvoiceID}\nCustomer {thing.CustomerID} {thing.CustomerName}\t\t{thing.InvoiceDate}";
                foreach (var li in combineLineItemsANDInventory)
                {
                    rightBox.Text += $"{li.LineNumber} {li.ItemName}\t @{li.ItemCost}\tqty sold {li.QuantitySold}\tcost {li.Cost:C2}";
                    //-total += li.Cost;
                }

            }
        }
    }
}
