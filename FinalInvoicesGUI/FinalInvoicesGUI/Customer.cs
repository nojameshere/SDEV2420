using System;
using System.Collections.Generic;
using System.Text;

namespace FinalInvoicesGUI
{

    class Customer
    {
        protected string first, last;
        protected int custID;
        public Customer(int customerID, string fname, string lname)
        {
            First = fname;
            Last = lname;
            CustomerID = customerID;
        }
        public string First
        {
            get { return first; }
            set { first = value; }
        }
        public string Last
        {
            get { return last; }
            set { last = value; }
        }
        public int CustomerID
        {
            get { return custID; }
            set { custID = value; }
        }
        public string Name
        {
            get { return first + " " + last; }
        }
    }
}
