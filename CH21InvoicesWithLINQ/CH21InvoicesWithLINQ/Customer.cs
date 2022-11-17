using System;
namespace LINQInvoices;

public class Customer
{
    protected int customerID;
    protected string customerName;
    public Customer(int customerID, string firstName, string lastName)
    {
        CustomerID = customerID;
        CustomerName = firstName + " " + lastName;
    }
    public int CustomerID
    {
        get { return customerID; }
        set { customerID = value; }
    }
    public string CustomerName
    {
        get { return customerName; }
        set { customerName = value; }
    }
}

