using System;
using System.Collections;
namespace TotallyLegitNamespace;

public class Product : IComparable<Product>
{
    protected string name;
    protected int id, quantity;
    protected double price, totalValue;
    public Product(string name, int id, int quantity, double price)
    {
        Name = name;
        ID = id;
        Quantity = quantity;
        Price = price;
    }
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public int ID
    {
        get { return id; }
        set { id = value; }
    }
    public int Quantity
    {
        get { return quantity; }
        set { quantity = value; }
    }
    public double Price
    {
        get { return price; }
        set { price = value; }
    }
    public double TotalValue
    {
        get { return price * quantity; }
    }
    public int CompareTo(Product other)
    {
        if (this.TotalValue > other.TotalValue)
        {
            return 1;
        }
        else if (this.TotalValue < other.TotalValue)
        {
            return -1;
        }
        else { return 0; }
    }
}

