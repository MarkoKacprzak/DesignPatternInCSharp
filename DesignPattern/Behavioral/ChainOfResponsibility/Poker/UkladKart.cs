using System.Collections.Generic;
using System.Linq;

namespace DesignPattern.Behavioral.ChainOfResponsibility.Poker
{
    abstract class UkladKart
    {
        public UkladKart ZarejestrujNastepny(UkladKart next)
        {
            Nastepny = next;
            return Nastepny;
        }

        protected UkladKart Nastepny { get; private set; }

        public abstract Uklad Uklad(RozdaneKarty karty);

        protected static bool WGrupie(int n, RozdaneKarty karty)
        {
            Dictionary<Figura, int> seen = new Dictionary<Figura, int>();

            foreach (Karta c in karty.Karty)
            {
                if (seen.ContainsKey(c.Figura))
                {
                    seen[c.Figura]++;
                }
                else
                {
                    seen[c.Figura] = 1;
                }
            }

            foreach (int count in seen.Values)
            {
                if (count == n)
                {
                    return true;
                }
            }

            return false;
        }

        protected static bool WStricie(RozdaneKarty karty)
        {
            List<Figura> values = karty.Karty.Select(c => c.Figura).ToList();
            values.Sort();

            int expectedValue = (int)values[0];

            foreach (Figura value in values)
            {
                if ((int)value != expectedValue)
                {
                    return false;
                }

                expectedValue++;
            }

            return true;
        }

        protected static bool WKolorze(RozdaneKarty karty)
        {
            List<Kolor> suits = karty.Karty.Select(c => c.Kolor).ToList();
            suits.Sort();

            Kolor expected = suits[0];

            return suits.All(suit => suit == expected);
        }
    }
}
