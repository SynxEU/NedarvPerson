using NedarvPerson;
using System;
using System.Collections.Generic;
namespace NedarvPerson
{
    class Program
    {
        static void Main()
        {
            // Opret et objekt af Person
            Person personObjekt = new Person("John", "Doe", 25);

            // Opret et objekt af Elev
            Elev elevObjekt = new Elev("Jane", "Doe", 18, 12);

            // Kald Udskriv-metoden via Person-objektet
            Console.WriteLine("Udskriv via Person-objektet:");
            personObjekt.Udskriv();

            // Kald Udskriv-metoden via Elev-objektet
            Console.WriteLine("\nUdskriv via Elev-objektet:");
            elevObjekt.Udskriv();

            // Person-objektets referencevariabel peger på Elev-objektet
            personObjekt = elevObjekt;

            // Kald Udskriv-metoden efter at have ændret referencevariablen
            Console.WriteLine("\nUdskriv via Person-objektet (nu peger det på Elev-objektet):");
            personObjekt.Udskriv();

            // Opret en List af Person-objekter
            List<Person> personListe = new List<Person>
            {
                new Person("Alice", "Johnson", 30),
                new Elev("Bob", "Smith", 17, 11)
            };

            // Udskrivning af objekter i listen med korrekt Udskriv-metode
            Console.WriteLine("\nUdskrivning af objekter i listen:");
            foreach (var person in personListe)
            {
                person.Udskriv();
            }
        }
    }
}
