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
            customers = new List<Customer>();
            loans = new List<Loan>();

            Customer cliente = new Customer("asd", "asd", "asd", 12);
            customers.Add(cliente);
        }
        public override string ToString()
        {
            return Name;
        }



   
        public void AddCustomer(string name, string lastname, string fiscalCode,int salary)
        {

            for( int i = 0; i < customers.Count; i++ )
            {
                if (customers[i].FiscalCode == fiscalCode )
                {
                     Console.WriteLine("Cliente già registrato");
                    return;
                }
            }
            Customer newCustomer = new Customer(name, lastname, fiscalCode, salary);
            customers.Add(newCustomer);
            Console.WriteLine("Cliente aggiunto");
        }

    }
}
