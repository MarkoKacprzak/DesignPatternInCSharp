namespace DesignPattern.Behavioral.ChainOfResponsibility.Poker
{
    class UkladKartPara : UkladKart
    {
        public override Uklad Uklad(RozdaneKarty hand)
        {
            if (WGrupie(2, hand))
            {
                return Poker.Uklad.Para;
            }

            return Nastepny.Uklad(hand);
        }
    }
}
