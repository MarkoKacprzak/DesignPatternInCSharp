namespace DesignPattern.Behavioral.ChainOfResponsibility.Poker
{
    class UkladKartPara : UkladKart
    {
        public override Uklad Uklad(RozdaneKarty karty)
        {
            if (WGrupie(2, karty))
            {
                return Poker.Uklad.Para;
            }

            return Nastepny.Uklad(karty);
        }
    }
}
