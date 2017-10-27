using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Behavioral.ChainOfResponsibility.Poker
{
    class RozdaneKarty
    {
        private readonly List<Karta> _karty = new List<Karta>();
        private Uklad _uklad = Uklad.Nic;

        public void Add(Karta c)
        {
            if(_karty.Count == 5)
            {
                throw new InvalidOperationException("Nie mozna dodac wiecej niz 5 kart.");
            }

            _karty.Add(c);

            if(_karty.Count == 5)
            {
                _karty.Sort();
                _uklad = UkladKartCiag.ZnajdzUklad(this);
            }
        }

        public Karta WysokaKarta
        {
            get
            {
                if(_karty.Count == 0)
                {
                    throw new InvalidOperationException();
                }

                return _karty[_karty.Count - 1];
            }
        }

        public IEnumerable<Karta> Karty => _karty;
        public Uklad Uklad =>_uklad;
        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (Karta karta in _karty)
            {
                sb.AppendFormat($"{karta},");
            }
            return sb.ToString();
        }
    }
}
