namespace DesignPattern.Behavioral.ChainOfResponsibility.Poker
{
    class UkladKartPokerKrolewski : UkladKart
    {
        public override Uklad Uklad(RozdaneKarty karty)
        {
            if(WKolorze(karty) && WStricie(karty) && karty.WysokaKarta.Figura == Figura.As)
            {
                return Poker.Uklad.PokerKrolewski;
            }

            return Nastepny.Uklad(karty);
        }
    }
}
