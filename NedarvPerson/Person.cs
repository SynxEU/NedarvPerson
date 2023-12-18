using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NedarvPerson
{
    public class Person
    {
        private string fornavn;
        private string efternavn;

        public string Navn => $"{fornavn} {efternavn}";
        public int Alder { get; set; }

        // Constructor
        public Person(string fornavn, string efternavn, int alder)
        {
            this.fornavn = fornavn;
            this.efternavn = efternavn;
            Alder = alder;
        }

        // Udskriv metode
        public virtual void Udskriv()
        {
            Console.WriteLine($"Navn: {Navn}, Alder: {Alder}");
        }
    }
}
