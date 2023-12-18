using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NedarvPerson
{
    public class Elev : Person
    {
        public int KlasseNr { get; set; }

        // Constructor med viderestilling ved hjælp af base
        public Elev(string fornavn, string efternavn, int alder, int klasseNr) : base(fornavn, efternavn, alder)
        {
            KlasseNr = klasseNr;
        }

        // Udskriv metode, der overskriver metoden i Person-klassen
        public override void Udskriv()
        {
            Console.WriteLine($"Navn: {Navn}, Alder: {Alder}, KlasseNr: {KlasseNr}");
        }
    }


}
