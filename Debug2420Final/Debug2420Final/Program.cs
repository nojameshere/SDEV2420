namespace Debug2420Final;

public class Program
{
    public static void Main(string[] arge)
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
            new LineItem(28, 6, 6238, 4)
        };

        void PrintInvoices()
        {
            var lines = from lineItem in lineItems
                           join item in inventory on lineItem.ItemID equals item.ItemID
                           select new
                           {
                               InvoiceNumber = lineItem.InvoiceID,
                               Line = lineItem.LineNumber,
                               ItemName = item.ItemName,
                               ItemCost = item.ItemCost,
                               Quantity = lineItem.Quantity,
                               Cost = lineItem.Quantity * item.ItemCost
                           };
            var combinedInvoices = from invoice in invoices
                                   join customer in customers on invoice.CustomerID equals customer.CustomerID
                                   select new
                                   {
                                       Number = invoice.InvoiceID,
                                       Name = customer.Name,
                                       InvoiceDate = invoice.InvoiceDate,
                                       CustomerNumber = customer.CustomerID
                                   };
            var invoicesGroupJoin = from invoice in combinedInvoices
                                    join item in lines on invoice.Number equals item.InvoiceNumber into gj
                                    select new
                                    {
                                        InvoiceNumber = invoice.Number,
                                        CustomerName = invoice.Name,
                                        InvoiceDate = invoice.InvoiceDate,
                                        CustomerNumber = invoice.CustomerNumber,
                                        InvoiceLineItems = gj
                                    };
            Console.WriteLine("Invoices\n");
            foreach (var invoice in invoicesGroupJoin)
            {
                double total = 0;
                Console.WriteLine($"\nInvoice {invoice.InvoiceNumber}");
                Console.WriteLine($"Customer {invoice.CustomerNumber} {invoice.CustomerName}\t{invoice.InvoiceDate}");
                foreach(var lineItem in invoice.InvoiceLineItems)
                {
                    Console.WriteLine($"{lineItem.Line} {lineItem.ItemName}\t@{lineItem.ItemCost:C2}\tqty sold {lineItem.Quantity}\tcost{lineItem.Cost:C2}");
                    total += lineItem.Cost;
                }
                Console.WriteLine($"Total for invoice: {total:C2}");
            }
        }
        void InventorySold()
        {
            var inventoryItem = from item in lineItems
                                join thing in inventory on item.ItemID equals thing.ItemID
                                join invoice in invoices on item.InvoiceID equals invoice.InvoiceID
                                select new
                                {
                                    InvoiceID = invoice.InvoiceID,
                                    Quantity = item.Quantity,
                                    Cost = item.Quantity * thing.ItemCost,
                                    ItemID = item.ItemID
                                };
            var itemGroupJoin = from item in lineItems
                                join thing in inventoryItem on item.ItemID equals thing.ItemID into gj
                                select new
                                {
                                    ItemNumber = item.ItemID,
                                    Invoices = gj
                                };
            
            Console.WriteLine("Inventory Changes");
            foreach (var item in itemGroupJoin)
            {
                double total = 0;
                Console.WriteLine($"\nInventory Item: {item.ItemNumber}");
                foreach (var invoice in item.Invoices)
                {
                    Console.WriteLine($"   Invoice {invoice.InvoiceID}\tsold {invoice.Quantity}\t cost {invoice.Cost:C2}");
                    total += invoice.Cost;
                }
                Console.WriteLine($"   Total sold: {total:C2}");
            }

        }
        void InvoicesByCustomer()
        {
            //join Line Items to Inventory Items
            //join the above as a group join to invoices
            //join the aboce as a group join to Customers
            var lineAndInventory = from line in lineItems
                                   join item in inventory on line.ItemID equals item.ItemID
                                   select new
                                   {
                                       Cost = item.ItemCost * line.Quantity,
                                       InvoiceID = line.InvoiceID,

                                   };
            var groupJoinInvoices = from invoice in invoices
                                    join item in lineAndInventory on invoice.InvoiceID equals item.InvoiceID into gj
                                    select new
                                    {
                                        InvoiceID = invoice.InvoiceID,
                                        CustomerID = invoice.CustomerID,
                                        Item = gj
                                    };
            var customerInvoiceGroupJoin = from customer in customers
                                           join invoice in groupJoinInvoices on customer.CustomerID equals invoice.CustomerID into gj
                                           orderby customer.CustomerID
                                           select new
                                           {
                                               CustomerID = customer.CustomerID,
                                               InvoiceData = gj
                                           };


            Console.WriteLine("Invoices Sorted by Customer");
            double grandTotal = 0;
            foreach (var customer in customerInvoiceGroupJoin)
            {
                Console.WriteLine($"\nCustomer {customer.CustomerID}");
                foreach (var invoice in customer.InvoiceData)
                {
                    Console.Write($"Invoice {invoice.InvoiceID}");
                    double invoiceTotal = 0;
                    foreach (var item in groupJoinInvoices)
                    {
                        foreach(var thing in item.Item)
                        {
                            invoiceTotal += thing.Cost;
                            grandTotal += thing.Cost;
                        }
                    }
                    Console.Write($" Total {invoiceTotal:C2}\n");
                }
            }
            Console.WriteLine($"Total \t\t{grandTotal:C2}");
        }


        PrintInvoices();
        InventorySold();
        InvoicesByCustomer();

        Console.WriteLine("\nPause");
        Console.ReadKey();
    }
}