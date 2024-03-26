using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_12_03_24
{
    internal class Postac
    {
        private string nazwa;
        private int poziom;//skrot - generowanie set i get
        private ERodzaj rodzaj;
        private ERasa rasa;

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
                $"Rodzaj postaci: {this.rodzaj}\nPoziom postaci: {this.poziom}");
        }
        //Metoda typu get (getter) - wyciąga dane z pola prywatnego
        public string GetNazwa()
        {
            return this.nazwa;
        }
        //Metoda set (Setter) - ustawia nową wartość nazwa
        public void SetNazwa(string nowaNazwa)
        {
            this.nazwa = nowaNazwa;
        }
        //Metoda Ustawiania poziomu (SET)
        public void SetPoziom(int poziom)
        {
            this.poziom = poziom;
        }
        //Metoda do powiekszania poziomu
        public void ZdobywajPoziom(ETypyPoziomu typZdobyciaPoziomu)
        {
            if (typZdobyciaPoziomu == ETypyPoziomu.Smoki)
            {
                this.poziom += (int)ETypyPoziomu.Smoki;
            }else if (typZdobyciaPoziomu == ETypyPoziomu.Gobliny)
            {
                this.poziom += (int)ETypyPoziomu.Gobliny;
            }else if (typZdobyciaPoziomu == ETypyPoziomu.Ryby)
            {
                this.poziom += (int)ETypyPoziomu.Ryby;
            }
        }
    }
}
