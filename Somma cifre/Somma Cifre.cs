using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;

namespace CorsoCSharp.Esercizi
{
    internal class Somma_Cifre
    {
        static void Main_Somma(string[] args)
        {
            // Esercizio: Somma Cifre
            // Chiedi all'utente un numero intero (es.123) e calcola la somma delle sue cifre (1+2+3=6)

            Console.WriteLine("Ciao, inserisci un numero: ");
            string testo = (Console.ReadLine());
            int valori = int.Parse(testo);
            int somma = 0;

            for (int i = 0; i < testo.Length; i++)
            {
                somma += (testo[i]);
            }
            Console.WriteLine($"La somma tra i valori di {valori} è pari a {somma}.");

        }
    }
}
