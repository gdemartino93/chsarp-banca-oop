using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chsarp_banca_oop
{
    internal class Bank
    {
        private string name;
        private List<Customer> customers;
        private List<Loan> loans;
        public string Name { get; set; }
        public Customer Customers { get; set; }
        public Loan Loans { get; set; }

        public Bank(string name)
        {
            Name = name;
 
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
