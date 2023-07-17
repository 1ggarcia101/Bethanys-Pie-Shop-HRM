using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.Accounting
{
    internal class Customer
    {
        private string customerID;
        private string customerName;

        public string CustomerID { get { return customerID; } set { customerID = value; } } 
        public string CustomerName { get {  return customerName; } set { customerName = value; } }
    }
}
