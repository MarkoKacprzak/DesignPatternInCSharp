using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPattern.Behavioral.ChainOfResponsibility.Poker
{
    class Stol
    {
        public Stol()
        {
            Karty = new Queue<Karta>();

            const int suitMin = (int)Kolor.Karo;
            const int suitMax = (int)Kolor.Pik;

            const int valueMin = (int)Figura.Dwojka;
            const int valueMax = (int)Figura.As;

            for (int s = suitMin; s <= suitMax; s++)
            {
                for (int v = valueMin; v <= valueMax; v++)
                {
                    Karty.Enqueue(new Karta((Kolor)s, (Figura)v));
                }
            }
        }

        public Karta Rozdaj()
        {
            return Karty.Dequeue();
        }

        public void Tasuj()
        {
            Tasuj(7);
        }

        public void Tasuj(int ile)
        {
            for (int i = 0; i < ile; i++)
            {
                Queue<Karta> nowyStol = new Queue<Karta>(Karty.OrderBy(a => Guid.NewGuid()));
                Karty = nowyStol;
            }
        }

        private Queue<Karta> Karty { get; set; }
    }
}
