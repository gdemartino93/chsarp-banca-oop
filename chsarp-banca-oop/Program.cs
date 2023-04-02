namespace chsarp_banca_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Customer> customers = new List<Customer>();
            List<Loan> loans = new List<Loan>();

            Bank sharpBank = new Bank("Sharp Bank",customers,loans);

           
        }
    }
}