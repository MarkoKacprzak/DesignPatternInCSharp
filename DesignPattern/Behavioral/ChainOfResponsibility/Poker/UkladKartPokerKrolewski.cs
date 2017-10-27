namespace DesignPattern.Behavioral.ChainOfResponsibility.Poker
{
    class UkladKartPokerKrolewski : UkladKart
    {
        public override Uklad Uklad(RozdaneKarty hand)
        {
            if(WKolorze(hand) && WStricie(hand) && hand.WysokaKarta.Figura == Figura.As)
            {
                return Poker.Uklad.PokerKrolewski;
            }

            return Nastepny.Uklad(hand);
        }
    }
}
