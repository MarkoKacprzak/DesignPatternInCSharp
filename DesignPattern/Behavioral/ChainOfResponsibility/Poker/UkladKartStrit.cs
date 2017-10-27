namespace DesignPattern.Behavioral.ChainOfResponsibility.Poker
{
    class UkladKartStrit : UkladKart
    {
        public override Uklad Uklad(RozdaneKarty hand)
        {
            if (WStricie(hand))
            {
                return Poker.Uklad.Strit;
            }

            return Nastepny.Uklad(hand);
        }
    }
}
