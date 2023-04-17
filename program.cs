using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Program
    {
        interface IWagaOceny
        {
            void przypiszWage();
        }
        interface IUsprawiedliw 
        {
            void usprawiedliwUcznia();
        }
        interface IZwolnij 
        {
            void akceptujZwolnienie();
        }
        abstract class AbstractOsoba
        {
            abstract public string imie { get; set; }
            public abstract string przedstaw();
        }
        class Nauczyciel : AbstractOsoba 
        {
            private List<Stopien> stopnie = new List<Stopien>();
            public override string imie { get; set; }
            public override string przedstaw()
            {
                return "na";
            }
            public void dodajOcene(Stopien st) 
            {
                stopnie.Add(st);
            }
            public void pokazOceny()
            {
                foreach (Stopien item in stopnie)
                {
                    Console.WriteLine(item.wartosc);
                }
            }
        }
        class Uczen : AbstractOsoba 
        {
            public override string imie { get; set; }
            public override string przedstaw()
            {
                return "uc";
            }
        }
        class Rodzic : AbstractOsoba, IUsprawiedliw 
        {
            public override string imie { get; set; }
            public override string przedstaw()
            {
                return "ro";
            }
            public void usprawiedliwUcznia() { }
        }
        abstract class AbstractAdmin : AbstractOsoba { }
        class Dyrektor { }
        class Wychowawca : AbstractAdmin, IZwolnij
        {
            public override string imie { get; set; }
            public override string przedstaw()
            {
                return "wy";
            }
            public void akceptujZwolnienie() { }
        }
        abstract class AbstractOcena
        {
            public string wartosc { get; set; }
        }
        class Stopien : AbstractOcena,IWagaOceny 
        {
            public void przypiszWage() { }
        }
        class Opisowa : AbstractOcena { }
        static void Main(string[] args)
        {
            Nauczyciel nau1 = new Nauczyciel();
            Console.WriteLine(nau1.przedstaw());

            Stopien stop1 = new Stopien();
            stop1.wartosc = "5";
            nau1.dodajOcene(stop1);
            nau1.pokazOceny();

            Console.ReadKey();
        }
    }
}
