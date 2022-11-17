using System;
namespace LINQInvoices;

public class Invoice
{
    protected int invoiceID, customerID;
    protected double invoiceTotal;
    protected DateTime invoiceDate;
    public Invoice(int invoiceID, int customerID, double invoiceTotal, int MM, int DD, int YYYY)
    {
        InvoiceID = invoiceID;
        CustomerID = customerID;
        InvoiceTotal = invoiceTotal;
        InvoiceDate = new DateTime(YYYY, MM, DD);
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
    public double InvoiceTotal
    {
        get { return invoiceTotal; }
        set { invoiceTotal = value; }
    }
    public DateTime InvoiceDate
    {
        get { return invoiceDate.Date; }
        set { invoiceDate = value; }
    }
}

