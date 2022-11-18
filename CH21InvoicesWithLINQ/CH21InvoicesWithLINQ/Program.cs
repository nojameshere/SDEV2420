using System.Collections;

namespace LINQInvoices;
public class Program
{
    public static void Main(string[] args)
    {
        double grandTotal = 0;
        Console.WriteLine("Chapter 21 Invoices with LINQ by James Sales");

        List<Customer> customers = new List<Customer>();
        List<Invoice> invoices = new List<Invoice>();

        //Add 4 customers
        customers.Add(new Customer(153, "James", "Sales"));
        customers.Add(new Customer(206, "Josh", "Beitler"));
        customers.Add(new Customer(199, "Tyler", "Bayne"));
        customers.Add(new Customer(112, "Millie", "Melton"));

        invoices.Add(new Invoice(19903, 153, 33.47, 11, 4, 2013));
        invoices.Add(new Invoice(32912, 112, 112.88, 12, 22, 2012));
        invoices.Add(new Invoice(75483, 199, 2018.12, 1, 1, 2018));
        invoices.Add(new Invoice(67483, 199, 1.99, 9, 6, 2019));
        invoices.Add(new Invoice(71798, 206, 218.99, 8, 17, 2011));
        invoices.Add(new Invoice(17890, 112, 8171.11, 8, 4, 2004));
        invoices.Add(new Invoice(11111, 199, 955.01, 5, 6, 2003));
        invoices.Add(new Invoice(18180, 153, 12.34, 5, 9, 2018));
        invoices.Add(new Invoice(22378, 206, 98.76, 5, 1, 2018));
        invoices.Add(new Invoice(99102, 206, 69, 6, 11, 2021));

        //list customers by customer ID
        Console.WriteLine("\nCustomers sorted by ID number");
        //LINQ sort by ID number of customer
        var byID = from customer in customers
                   orderby customer.CustomerID
                   select customer;

        foreach(Customer customer in byID)
        {
            Console.WriteLine($"{customer.CustomerID} {customer.CustomerName}");
        }

        //LINQ sort by name of customer
        Console.WriteLine("\nCustomers sorted by customer name");
        var byName = from customer in customers
                     orderby customer.CustomerName
                     select customer;

        foreach(Customer customer in byName)
        {
            Console.WriteLine($"{customer.CustomerID} {customer.CustomerName}");
        }

        //LINQ sort invoices by invoice ID
        Console.WriteLine("\nInvoices sorted by invoice ID");
        var invoiceByID = from invoice in invoices
                          orderby invoice.InvoiceID
                          select invoice;

        foreach(Invoice invoice in invoices)
        {
            Console.WriteLine($"Invoice {invoice.InvoiceID}\t{invoice.CustomerID}\t{invoice.InvoiceDate.ToShortDateString()}\t{invoice.InvoiceTotal:C2}");
        }

        //LINQ group join - list invoices by customer
        Console.WriteLine("\nList invoices grouped by customer");
        var byCustomer = from customer in customers
                         join invoice in invoices on customer.CustomerID equals invoice.CustomerID into groupJoin
                         select new
                         {
                             CustomerID = customer.CustomerID,
                             GroupedInvoices = groupJoin
                         };

        foreach(var item in byCustomer)
        {
            double totalForCustomer = 0;
            //This prints the customer ID
            Console.WriteLine($"\nCustomer {item.CustomerID}");

            //This prints the invoices which match the customer's ID
            foreach(var invoice in item.GroupedInvoices)
            {
                Console.WriteLine($"    {invoice.InvoiceID}, {invoice.InvoiceDate.ToShortDateString()}, \t{invoice.InvoiceTotal:C2}");
                totalForCustomer += invoice.InvoiceTotal;
            }
            Console.WriteLine($"Total for customer: {totalForCustomer:C2}");
            grandTotal += totalForCustomer;
        }
        Console.WriteLine($"\nTotal for all invoices: {grandTotal:C2}");

        //Program pause statement
        Console.WriteLine("\n\n\nPress key to continue.");
        Console.ReadKey();
    }
}