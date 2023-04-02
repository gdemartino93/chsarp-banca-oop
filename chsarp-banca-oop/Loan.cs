using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chsarp_banca_oop
{
    internal class Loan
    {
        private int id;
        private Customer customer;
        private int totalLoan;
        private int installment;

        public int Id { get; set; }
        public Customer Customer { get; set; }
        public int TotalLoan { get; set; }
        public int Installment { get; set; }

        public Loan(int id, Customer customer, int totalLoan, int installment)
        {
            Id = id;
            Customer = customer;
            TotalLoan = totalLoan;
            Installment = installment;
        }
    }
}
