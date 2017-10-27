namespace DesignPattern.Behavioral.ChainOfResponsibility.Poker
{
    class UkladKartPoker : UkladKart
    {
        public override Uklad Uklad(RozdaneKarty karty)
        {
            if (WKolorze(karty) && WStricie(karty))
            {
                return Poker.Uklad.Poker;
            }

            return Nastepny.Uklad(karty);
        }
    }
}
