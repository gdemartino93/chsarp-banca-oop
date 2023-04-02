namespace chsarp_banca_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string spacer = "-----------------------------------------";

            List<Customer> customers = new List<Customer>();
            List<Loan> loans = new List<Loan>();

            Bank sharpBank = new Bank("Sharp Bank");
            Console.WriteLine($"Software Gestionale - {sharpBank.Name}");
            Console.WriteLine(spacer);

            Console.WriteLine("Menu");
            Console.WriteLine(spacer);
            Console.WriteLine("Seleziona l'azione che vuoi eseguire digitando il numero");
            Console.WriteLine();
            Console.WriteLine("[1] Aggiungi Cliente");
            Console.WriteLine("[2] Modifica Cliente");
            Console.WriteLine("[3] Ricerca Cliente");
            Console.WriteLine("[4] Ricerca prestito Cliente");
            Console.WriteLine("[5] Aggiungi prestito");
            Console.WriteLine("[6] Prospetto prestiti bamca");
            Console.WriteLine("[7] Prospetto prestiti");
            Console.WriteLine("[8] Esci");
            Console.WriteLine(spacer);

            int scelta = Convert.ToInt32(Console.ReadLine());



        }
    }
}