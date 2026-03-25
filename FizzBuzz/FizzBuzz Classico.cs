using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Linq;

namespace CorsoCSharp.Esercizi
{
    internal class FizzBuzz_Classico
    {
        static void Main_FizzBuzz(string[] args)
        {
            // Esercizio: FizzBuzz classico
            // Scrivi un programma che stampi i numeri da 1 a 50.
            // Per i multipli di 3 stampa "Fizz" al posto del numero.
            // Per i multipli di 5 stampa "Buzz".
            // Per i multipli di ENTRAMBI, stampa "FizzBuzz".

            //for (int valore = 1; valore <= 50; valore++)
            //{
            //    if ((valore == 3) || (valore == 6) || (valore == 9) || (valore == 12) || (valore == 18) || (valore == 21)
            //        || (valore == 24) || (valore == 27) || (valore == 33) || (valore == 36) || (valore == 39)
            //        || (valore == 42) || (valore == 48))
            //        Console.WriteLine("Fizz");
            //    else if ((valore == 5) || (valore == 10) || (valore == 20) || (valore == 25)
            //        || (valore == 35) || (valore == 40) || (valore == 50)) Console.WriteLine("Buzz");
            //    else if ((valore == 15) || (valore == 30) || (valore == 45)) Console.WriteLine("FizzBuzz");
            //    else Console.WriteLine(valore);
            //}

            // Sopra è corretto, ma è possibile ridurre la linea di codice come segue:

            for(int valore = 1; valore <=50; valore++)
            {
                if ((valore % 5 == 0 && valore % 3 == 0)) Console.WriteLine("FizzBuzz");
                else if (valore % 5 == 0) Console.WriteLine("Buzz");
                else if (valore % 3 == 0) Console.WriteLine("Fizz");
                else Console.WriteLine(valore);
            }



        }
    }
}
