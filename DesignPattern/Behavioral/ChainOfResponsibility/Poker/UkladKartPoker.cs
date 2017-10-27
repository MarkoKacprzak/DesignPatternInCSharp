namespace DesignPattern.Behavioral.ChainOfResponsibility.Poker
{
    class UkladKartPoker : UkladKart
    {
        public override Uklad Uklad(RozdaneKarty hand)
        {
            if (WKolorze(hand) && WStricie(hand))
            {
                return Poker.Uklad.Poker;
            }

            return Nastepny.Uklad(hand);
        }
    }
}
