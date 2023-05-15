using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    //Zadanie 1
    public abstract class AbstractClass
    {
        public abstract void Wykonaj();
    }
    public class Class1 : AbstractClass
    {
        public override void Wykonaj()
        {
            Console.WriteLine("Wykonuję");
        }
    }
    public class Class2 : AbstractClass
    {
        public override void Wykonaj()
        {
            Console.WriteLine("Wykonuję");
        }
    }
    public class Class3 : AbstractClass
    {
        public override void Wykonaj()
        {
            Console.WriteLine("Wykonuję");
        }
    }

    //Zadanie 2
    public interface Interface1
    {
        void Rusz();
    }
    public interface Interface2
    {
        void Stworz();
    }
    public class Class4 : Interface1
    {
        public void Rusz()
        {
            Console.WriteLine("Ruszam");
        }
    }
    public class Class5 : Interface2
    {
        public void Stworz()
        {
            Console.WriteLine("Tworzę");
        }
    }
    public class Class6 : Interface1, Interface2
    {
        public void Rusz()
        {
            Console.WriteLine("Ruszam");
        }
        public void Stworz()
        {
            Console.WriteLine("Tworzę");
        }
    }
    public class Class7 : Interface1, Interface2
    {
        public void Rusz()
        {
            Console.WriteLine("Ruszam");
        }
        public void Stworz()
        {
            Console.WriteLine("Tworzę");
        }
    }

    //Zadanie 3
    public class Liczba
    {
        public virtual void Wczytaj(){ }
        public virtual void Wypisz(){ }
    }
    public class Nint : Liczba
    {
        public int Wartosc { get; set; }
        public override void Wczytaj()
        {
            Console.WriteLine("Podaj wartość (typ int): ");
            Wartosc = int.Parse(Console.ReadLine());
        }
        public override void Wypisz()
        {
            Console.WriteLine("Wartość (typ int): " + Wartosc);
        }
    }
    public class Ndouble : Liczba
    {
        public double Wartosc { get; set; }
        public override void Wczytaj()
        {
            Console.WriteLine("Podaj wartość (typ double): ");
            Wartosc = double.Parse(Console.ReadLine());
        }
        public override void Wypisz()
        {
            Console.WriteLine("Wartość (typ double): " + Wartosc);
        }
    }

    //Zadanie 4
    public class Towar
    {
        public string Nazwa { get; set; }
        public double Cena { get; set; }
        public int Ilosc { get; set; }
        public virtual void Opis()
        {
            Console.WriteLine("Nazwa: " + Nazwa);
            Console.WriteLine("Cena: " + Cena);
            Console.WriteLine("Ilość: " + Ilosc);
        }
    }
    public class Gwozdzie : Towar
    {
        public int Dlugosc { get; set; }
        public int Grubosc { get; set; }
        public string RodzajLepka { get; set; }
        public override void Opis()
        {
            base.Opis();
            Console.WriteLine("Długość: " + Dlugosc);
            Console.WriteLine("Grubość: " + Grubosc);
            Console.WriteLine("Rodzaj lepka: " + RodzajLepka);
        }
    }
    public class PapierScierny : Towar
    {
        public int Ziarnistosc { get; set; }
        public int Szerokosc { get; set; }

        public override void Opis()
        {
            base.Opis();
            Console.WriteLine("Ziarnistość: " + Ziarnistosc);
            Console.WriteLine("Szerokość: " + Szerokosc);
        }
    }
    public class Meble : Towar
    {
        public string Kolekcja { get; set; }

        public override void Opis()
        {
            base.Opis();
            Console.WriteLine("Kolekcja: " + Kolekcja);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Zadanie 1
            List<AbstractClass>List1 = new List<AbstractClass>();
            List1.Add(new Class1());
            List1.Add(new Class2());
            List1.Add(new Class3());
            List1.Add(new Class1());
            List1.Add(new Class2());
            List1.Add(new Class3());

            //Zadanie 2
            List<Interface1> List2 = new List<Interface1>();
            List2.Add(new Class4());
            List2.Add(new Class6());
            List2.Add(new Class7());
            foreach (Interface1 i in List2)
            {
                i.Rusz();
            }

            List<Interface2> List3 = new List<Interface2>();
            List3.Add(new Class5());
            List3.Add(new Class6());
            List3.Add(new Class7());
            foreach (Interface2 i in List3)
            {
                i.Stworz();
            }
            
            //Zadanie 3
            Nint nInt = new Nint();
            Ndouble nDouble = new Ndouble();

            nInt.Wczytaj();
            nDouble.Wczytaj();
            nInt.Wypisz();
            nDouble.Wypisz();

            //Zadanie 4
            Gwozdzie gwozdzie = new Gwozdzie();
            gwozdzie.Nazwa = "Gwoździe";
            gwozdzie.Cena = 1.99;
            gwozdzie.Ilosc = 100;
            gwozdzie.Dlugosc = 5;
            gwozdzie.Grubosc = 2;
            gwozdzie.RodzajLepka = "Standardowy";

            PapierScierny papierScierny = new PapierScierny();
            papierScierny.Nazwa = "Papier ścierny";
            papierScierny.Cena = 3.49;
            papierScierny.Ilosc = 25;
            papierScierny.Ziarnistosc = 100;
            papierScierny.Szerokosc = 20;

            Meble meble = new Meble();
            meble.Nazwa = "Stół";
            meble.Cena = 249.99;
            meble.Ilosc = 10;
            meble.Kolekcja = "Klasyczna";

            gwozdzie.Opis();
            Console.WriteLine();
            papierScierny.Opis();
            Console.WriteLine();
            meble.Opis();

            Console.ReadKey();
        }
    }
}
