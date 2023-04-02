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
        private DateTime startDate;
        private DateTime endDate;

        public int Id { get; set; }
        public Customer Customer { get; set; }
        public int TotalLoan { get; set; }
        public int Installment { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public Loan(int id, Customer customer, int totalLoan, int installment, DateTime startDate, DateTime endDate)
        {
            Id = id;
            Customer = customer;
            TotalLoan = totalLoan;
            Installment = installment;
            StartDate = startDate;
            EndDate = endDate;
        }
        public override string ToString()
        {
            return $"Prestito id: {Id} - Cliente: {Customer.Name} {Customer.Lastname}. Totale del prestito: {TotalLoan} - Rata: {Installment}. Data inizio prestito: {StartDate} - Data fine prestito {EndDate}";
        }
    }
}
