using System;
using System.Collections.Generic;
using System.Text;

namespace CorsoCSharp.Esercizi
{
    internal class Password
    {
        static void Main_Password(string[] args)
        {
            // Esercizio: Generatore di Password "Smart"
            // Crea un programma che generi una password casuale di 12 caratteri.
            // La password deve avere obbligatoriamente:
            // (1) Almeno una lettera maiuscola.
            // (2) Almeno un numero.
            // (3) Almeno un carattere speciale.

            string LetterePossibili = "abcdefghijkmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string NumeriPossibili = "0123456789";
            string Speciali = "!@#$";
            string Totale = LetterePossibili + NumeriPossibili + Speciali;
            var rdn = new Random();
            var password = "";

            // Forzo l'inserimento dei requisiti (almeno un numero/almeno un carattere speciale)
            password += NumeriPossibili[rdn.Next(NumeriPossibili.Length)];
            password += Speciali[rdn.Next(Speciali.Length)];

            for (int i = 0; i <= 10; i++) // <- Inserisco 10 e non 12 in quanto due posizioni sono già state assegnate
            { 
                password += Totale[rdn.Next(Totale.Length)];
            }
            Console.WriteLine($"La password generata randomicamente è: {password}");

        }
    }
}
