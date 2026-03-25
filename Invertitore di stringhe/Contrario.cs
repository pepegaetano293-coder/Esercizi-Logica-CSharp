using System;
using System.Collections.Generic;
using System.Text;

namespace CorsoCSharp.Esercizi
{
    internal class Contrario
    {
        static void Main(string[] args)
        {
            // Esercizio: Invertitore di stringhe
            // Chiedi all'utente una parola e stampala al contrario senza
            // usare funzioni integrate come Reverse(). Usa un Ciclo For

            Console.WriteLine("Scrivi una parola: ");

            string risposta = Console.ReadLine();
            string risposta_invertita = "";
            
            // La logica che c'è dietro il ciclo for è il seguente:
            // 1. Si parte dall'ULTIMO INDICE della parola scritta dall'utente (di conseguenza: risposta.Length -1)
            // 2.Continua fino a quando "item" è maggiore o uguale a 0.
            // 3. Ado ogni passo sottrae 1 a "item" (item--)

            for(int item = risposta.Length -1; item >= 0; item--)
            {
                risposta_invertita += risposta[item]; // <-Prendiamo il carattere alla posizione i-esima e lo "attacchiamo" alla nuova stringa
            }
            Console.WriteLine($"La parola invertita è: {risposta_invertita}");
        }
    }
}
