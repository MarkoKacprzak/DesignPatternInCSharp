namespace DesignPattern.Behavioral.ChainOfResponsibility.Poker
{
    class UkladKartKareta : UkladKart
    {
        public override Uklad Uklad(RozdaneKarty hand)
        {
            if (WGrupie(4, hand))
            {
                return Poker.Uklad.Kareta;
            }

            return Nastepny.Uklad(hand);
        }
    }
}
