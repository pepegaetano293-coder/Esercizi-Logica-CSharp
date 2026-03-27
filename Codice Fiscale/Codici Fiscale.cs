using System;
using System.Collections.Generic;
using System.Text;

namespace CorsoCSharp.Esercizi
{
    internal class Codici_Fiscale
    {
        static void Main_CF(string[] args)
        {
            // Esercizio: Il validatore di Codici Fiscali
            // Immagina di dover creare un sistema che verifichi se un codice identificativo
            // inserito da un utente è scritto correttamente secondo queste regole specifiche:
            // (1) deve avere esattamente 8 caratteri.
            // (2) i PRIMI DUE CARATTERI devono avere LETTERE MAIUSCOLE.
            // (3) I SUCCESSIVI 4 CARATTERI devono essere NUMERI.
            // (4) GLI ULTIMI DUE CARATTERI devono essere SIMBOLI SPECIALI scelti tra questi: !, ?, #, *

            // L'obiettivo del programma è il seguente:
            // Chiedi all'utente di inserire il codice.
            // Analizza il codice carattere per carattere
            // usando un ciclo o una serie di controlli.

            string Lettere = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string Numeri = "0123456789";
            string Speciali = "!?#*";
            string Totale = Lettere + Numeri + Speciali;


            Console.WriteLine("Ciao, inserisci il codice: ");
            var risposta = Console.ReadLine().Trim();
            
            if(risposta.Length != 8)
            {
                Console.WriteLine($"Errore.Lunghezza errata ({risposta.Length} / 8)");
            }


            bool tuttoOk = true; // <- BANDIERA (se qualcosa va storto nei passi IF, lo segna.

            for(int i = 0; i<= 1; i++)
            {
                if(!char.IsUpper(risposta[i]))
                {
                    Console.WriteLine($"Errore. La lettera '{risposta[i]}' deve essere maiuscola!");
                    tuttoOk = false;
                }
            }
            for(int i = 2; i <= 5; i++)
            {
                if(!char.IsDigit(risposta[i]))
                {
                    Console.WriteLine($"Errore. {risposta[i]} non è un numero.");
                    tuttoOk = false;
                }
            }
            for(int i = 6; i <=7; i++)
            {
                if (!Speciali.Contains(risposta[i]))
                {
                    Console.WriteLine($"Errore. '{risposta[i]}' non è un simbolo speciale (!?#*)");
                    tuttoOk = false;
                }
            }
            if (tuttoOk) Console.WriteLine("Codice Perfetto!");
            else Console.WriteLine("Codice Errato!");
        }
    }
}
