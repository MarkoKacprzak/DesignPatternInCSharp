namespace DesignPattern.Behavioral.ChainOfResponsibility.Poker
{
    class UkladKartKolor : UkladKart
    {
        public override Uklad Uklad(RozdaneKarty karty)
        {
            if (WKolorze(karty))
            {
                return Poker.Uklad.Kolor;
            }

            return Nastepny.Uklad(karty);
        }
    }
}
