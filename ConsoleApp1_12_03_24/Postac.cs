using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_12_03_24
{
    internal class Postac
    {
        public string nazwa;
        public int poziom { get; private set; }//skrot - generowanie set i get
        public ERodzaj rodzaj;
        public ERasa rasa;

        //Metoda konstruktora:
        public Postac(string nazwa, ERodzaj rodzaj, ERasa rasa) 
        {
            this.nazwa = nazwa;
            this.rasa = rasa;
            this.rodzaj = rodzaj;
            this.poziom = 0;
        }

        public void wypiszDanePostaci()
        {
            Console.WriteLine($"Nazwa postaci: {this.nazwa}\nRasa postaci: {this.rasa}\n" +
                $"Rodzaj postaci: {this.rodzaj}");
        }

    }
}
