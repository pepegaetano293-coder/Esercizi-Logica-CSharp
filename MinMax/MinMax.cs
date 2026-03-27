using System;
using System.Collections.Generic;
using System.Text;

namespace CorsoCSharp.Esercizi
{
    internal class MinMax
    {
        static void Main(string[] args)
        {
            // Esercizio: Chiedi all'utente quanti numeri vuole inserire.
            // Poi, tramite un ciclo, chiedigli di digitarli uno alla volta.
            // Alla fine, stampa il numero più grande e quello più piccolo che è stato inserito.

            Console.WriteLine("Ciao, quanti numeri vuoi inserire?");
            int quantità = int.Parse(Console.ReadLine());

            // Inizializzo i valori
            int massimo = int.MinValue; // Il numero più grande possibile
            int minimo = int.MaxValue; // Il numero più piccolo possibile

            for(int i = 0; i < quantità; i++)
            {
                Console.WriteLine($"Inserisci il numero {i +1}");
                int numeroInserito = int.Parse(Console.ReadLine());

                if (numeroInserito > massimo)
                {
                    massimo = numeroInserito;
                }
                if (numeroInserito < minimo)
                {
                    minimo = numeroInserito;
                }
            }
            Console.WriteLine($"Il valore massimo è {massimo} mentre il valore minimo è {minimo}");

        }
    }
}
