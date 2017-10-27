namespace DesignPattern.Behavioral.ChainOfResponsibility.Poker
{
    class UkladKartKolor : UkladKart
    {
        public override Uklad Uklad(RozdaneKarty hand)
        {
            if (WKolorze(hand))
            {
                return Poker.Uklad.Kolor;
            }

            return Nastepny.Uklad(hand);
        }
    }
}
