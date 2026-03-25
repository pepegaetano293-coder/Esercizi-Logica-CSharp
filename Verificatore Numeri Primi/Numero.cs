using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace CorsoCSharp.Esercizi
{
    internal class Numero
    {
        static void Main_Numeri(string[] args)
        {
            // Esercizio: Verificatore dei numeri Primi
            // Crea un programma che riceve un numero intero e determini 
            // se è un numero Primo (divisibile solo per 1 e per se stesso)

            Console.WriteLine("Ciao, scrivi un numero: ");
            int numero = Int32.Parse(Console.ReadLine());
            bool DivisoreTrovato = true; // <- Parto dal presupposto che NON è primo

            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                {
                    DivisoreTrovato = false;
                    break;
                }
            }
            if (DivisoreTrovato) Console.WriteLine($"{numero} => Numero Primo.");
            else Console.WriteLine($"{numero} => Numero Composto.");
        }
    }
}
