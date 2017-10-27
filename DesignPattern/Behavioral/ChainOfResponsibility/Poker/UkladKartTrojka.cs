namespace DesignPattern.Behavioral.ChainOfResponsibility.Poker
{
    class UkladKartTrojka : UkladKart
    {
        public override Uklad Uklad(RozdaneKarty hand)
        {
            if (WGrupie(3, hand))
            {
                return Poker.Uklad.Trojka;
            }

            return Nastepny.Uklad(hand);
        }
    }
}
