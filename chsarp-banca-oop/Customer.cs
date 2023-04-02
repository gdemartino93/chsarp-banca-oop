using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chsarp_banca_oop
{
    internal class Customer
    {
        private string name;
        private string lastname;
        private string fiscalCode;
        private int salary;

        public string Name { get; set; }
        public string Lastname { get; set; }
        public string FiscalCode { get; set; }
        public int Salary { get; set; }

        public Customer(string name, string lastname,string fiscalCode, int salary)
        {
            Name = name;
            Lastname = lastname;
            FiscalCode = fiscalCode;
            Salary = salary;
        }
        public void ToString()
        {
            Console.WriteLine($"{Name} {Lastname} - CF: {FiscalCode} - Stipendio: {Salary}");
        }
    }
}
