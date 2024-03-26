using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_12_03_24
{
    internal class Osoba
    {
        public string imie;//Pole/Właściwośc/atrybuty klasy
        private string nazwisko;
        private int wiek;
        //Metoda Konstruktora (wywoływana gdy tworzymy nowy obiekt)
        public Osoba(string pobraneImie, string pobraneNazwisko, int pobranyWiek) {
            this.imie = pobraneImie;
            this.nazwisko = pobraneNazwisko;
            this.wiek = pobranyWiek;
        }
        //Metoda w klasie Osoba
        public void PobierzPersonalia()
        {
            Console.WriteLine($"Imię: {this.imie}\nNazwisko: {this.nazwisko}\n" +
                                $"wiek: {this.wiek}");
        }
        //Metoda set (setter) która ustawia wartość w klasie.
        public void SetNazwisko( string nazwisko )
        {
            this.nazwisko = nazwisko;
        }
        //Metoda get (getter) pobiera nam i zwraca określone pole
        public string GetNazwisko() 
        {  
            return this.nazwisko; 
        }
    }
}
