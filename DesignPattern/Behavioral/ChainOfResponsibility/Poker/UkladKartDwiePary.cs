using System.Collections.Generic;

namespace DesignPattern.Behavioral.ChainOfResponsibility.Poker
{
    class UkladKartDwiePary : UkladKart
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

            if (seen.Count == 3)
            {
                int twoSeen = 0;
                int oneSeen = 0;
                foreach (int val in seen.Values)
                {
                    switch (val)
                    {
                        case 1:
                            oneSeen++;
                            break;
                        case 2:
                            twoSeen++;
                            break;
                        default:
                            break;
                    }
                }

                if (oneSeen == 1 && twoSeen == 2)
                {
                    return Poker.Uklad.DwiePary;
                }
            }

            return Nastepny.Uklad(hand);
        }
    }
}
