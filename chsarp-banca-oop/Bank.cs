using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
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

            Customer cliente = new Customer("helloname", "hellolastname", "asdasdasdasdasda", 12);
            DateTime dataInizio = DateTime.Parse("12/01/2000");
            DateTime dataFine = DateTime.Parse("12/12/2001");
            Loan prestito1 = new Loan(1, cliente, 1000, 100,dataInizio,dataFine);
            customers.Add(cliente);
            loans.Add(prestito1);
        }
        public override string ToString()
        {
            return Name;
        }

        public void GetAllCustomers()
        {
            for ( int i = 0; i < customers.Count; i++)
            {
                customers[i].ToString();
            }
        }
        public void GetAllLoans()
        {
            for (int i = 0;i < loans.Count; i++)
            {
                loans[i].ToString();
            }
        }
        public void AddCustomer(string name, string lastname, string fiscalCode, int salary)
        {
            for (int i = 0; i < customers.Count; i++)
            {
                if (customers[i].FiscalCode == fiscalCode)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Cliente già registrato");
                    Console.ResetColor();
                    return;
                }
            }

            while (fiscalCode.Length != 16)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Codice fiscale Errato. Il cf deve avere 16 caratteri");
                Console.WriteLine("Reinserisci il codice fiscale:");
                Console.ResetColor();

                fiscalCode = Console.ReadLine();
            }

            Customer newCustomer = new Customer(name, lastname, fiscalCode, salary);
            customers.Add(newCustomer);
            Console.WriteLine("Cliente aggiunto");
        }

        public Customer SearchCustomer(string fiscalCode)
        {
            foreach(Customer customer in customers)
            {
                if(fiscalCode.ToLower() == customer.FiscalCode.ToLower())
                {
                    return customer;
                }
            }
            return null;
        }
        public bool EditCustomer(string nome,string lastname,string fiscalCode,int salary)
        {
            Customer editCustomer = SearchCustomer(fiscalCode);
            if (editCustomer != null)
            {
                if(nome != "")
                {
                    editCustomer.Name = nome;
                }
                if(lastname != "")
                {
                    editCustomer.Lastname = lastname;
                }
                if(fiscalCode != "" && fiscalCode.Length == 16)
                {
                    editCustomer.FiscalCode = fiscalCode;
                }
                if(salary >= 0)
                {
                    editCustomer.Salary = salary;
                }

                return true;

            }
            else
            { 
                return false;
            }
        }
        public List<Loan> CustomerLoan(string fiscalCode)
        {
            Customer customer = SearchCustomer(fiscalCode);
            if(customer == null)
            {
                return null;
            }
            List <Loan> customerLoans = new List<Loan>();
            foreach(Loan loan in loans)
            {
                if(loan.Customer.FiscalCode == customer.FiscalCode)
                {
                    customerLoans.Add(loan);
                }
            }
            return loans;
        }


        public void AddLoan(Loan newLoan)
        {
            loans.Add(newLoan);
        }
    }
}
