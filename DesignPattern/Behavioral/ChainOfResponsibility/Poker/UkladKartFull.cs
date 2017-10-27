using System.Collections.Generic;

namespace DesignPattern.Behavioral.ChainOfResponsibility.Poker
{
    class UkladKartFull : UkladKart
    {
        public override Uklad Uklad(RozdaneKarty hand)
        {
            Dictionary<Figura, int> seen = new Dictionary<Figura, int>();

            foreach (Karta c in hand.Karty)
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

            if (seen.Count == 2)
            {
                if(seen.ContainsValue(3) && seen.ContainsValue(2))
                {
                    return Poker.Uklad.Full;
                }
            }

            return Nastepny.Uklad(hand);
        }
    }
}
