namespace chsarp_banca_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string spacer = "-----------------------------------------";


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


            
            switch (scelta)
            {
            
            case 1:
                    Console.WriteLine("Aggiungi cliente");
                    Console.WriteLine(spacer);
                    Console.WriteLine("Inserisci nome cliente");
                    string name = Console.ReadLine();
                    Console.WriteLine("Inserisci cognome cliente");
                    string lastname = Console.ReadLine();
                    Console.WriteLine("Inserisci codice fiscale del cliente");
                    string fiscalCode = Console.ReadLine();
                    Console.WriteLine("Inserisci lo stipendio del cliente");
                    int salary = Convert.ToInt32(Console.ReadLine());
                    sharpBank.AddCustomer(name, lastname, fiscalCode, salary);
                    break;
            case 2:
                    Console.WriteLine("adasd");
                    break;
            }

            sharpBank.GetAllCustomers();
        }
    }
}