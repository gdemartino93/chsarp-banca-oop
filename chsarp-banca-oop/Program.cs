﻿using System.Threading.Channels;

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
            Console.WriteLine("[4] Ricerca prestiti di un Cliente");
            Console.WriteLine("[5] Ottieni il totale in euro dei prestiti per un Cliente");
            Console.WriteLine("[6] Ottieni il numero totale RESIDUO di rate da pagare per un Cliente");
            Console.WriteLine("[7] Esci");
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
                    Console.WriteLine("Inserisci il cf del cliente");
                    string customerFiscalCode = Console.ReadLine();
                    Customer customerToEdit = sharpBank.SearchCustomer(customerFiscalCode); //recuperiamo il cliente da modificare
                    if(customerToEdit != null)
                    {
                        Console.WriteLine("Inserisci il nuovo nome");
                        string newName = Console.ReadLine();
                        Console.WriteLine("Inserisci il nuovo cognome");
                        string newLastname = Console.ReadLine();
                        Console.WriteLine("Inserisc il nuovo codice fiscale");
                        string newFiscalCode = Console.ReadLine();
                        Console.WriteLine("Inserisci il nuovo stipendio");
                        int newSalary = Convert.ToInt32(Console.ReadLine());

                        //aggiorniamo i dati del cliente recuperato
                        customerToEdit.Name = newName;
                        customerToEdit.Lastname = newLastname;
                        customerToEdit.FiscalCode = newFiscalCode;
                        customerToEdit.Salary = newSalary;

                        Console.WriteLine("Il cliente è stato aggiornato!");
                    }
                    else
                    {
                        Console.WriteLine("Nessun cliente trovato");
                    }
                    break;
                case 3:
                    Console.WriteLine("Inserisci il codice fiscale dell'utente da cercare:");
                    string search = Console.ReadLine(); //codice fiscale da cercare
                    Customer customerFounded = sharpBank.SearchCustomer(search); //ci ritorna l'oggetto customer cercato
                    customerFounded.ToString(); //metodo tostring per stampare l'oggetto cercato
                    break;
                case 4:
                    Console.WriteLine("Inserisci il codice fiscale dell'utente da cercare");
                    search = Console.ReadLine();

                    List<Loan> loansCustomer = sharpBank.CustomerLoan(search);
                    foreach(Loan loan in loansCustomer)
                    {
                        Console.WriteLine(spacer);
                        loan.ToString();
                        Console.WriteLine(spacer);
                    }

                    break;
                case 5:
                    Console.WriteLine("Inserisci il codice fiscale dell'utente da cercare");
                    search = Console.ReadLine();
                    Console.WriteLine($"Il totale dei prestiti del cliente cercato è: {sharpBank.TotalAmountLoan(search)} euro");

                    break;
                case 6:
                    Console.WriteLine("Inserisci il codice fiscale dell'utente da cercare");
                    search = Console.ReadLine();
                    Console.WriteLine($"Il totale di rate del cliente cercato, ancora da pagare, è: {sharpBank.NumberOfInstallmentUser(search)}");
                    break;
              
            }

        }
    }
}