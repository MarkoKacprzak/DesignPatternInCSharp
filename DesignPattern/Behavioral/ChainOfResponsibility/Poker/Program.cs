using System;
using System.Collections.Generic;

namespace DesignPattern.Behavioral.ChainOfResponsibility.Poker
{
    public class Sample : ISample
    {
        public void Run()
        {
            var rozdaneKarty = new RozdaneKarty[10];
            var stol = new Stol();
            stol.Tasuj();

            for (int i = 0; i < rozdaneKarty.Length; i++)
            {
                rozdaneKarty[i] = new RozdaneKarty();
            }

            for (int iloscKart = 0; iloscKart < 5; iloscKart++)
            {
                foreach (RozdaneKarty t in rozdaneKarty)
                {
                    t.Add(stol.Rozdaj());
                }
            }

            foreach (var karty in rozdaneKarty)
            {
                Console.WriteLine($"{karty.Uklad} ({karty}) Najwyzsza karta: {karty.WysokaKarta}");
            }
        }
    }
}
