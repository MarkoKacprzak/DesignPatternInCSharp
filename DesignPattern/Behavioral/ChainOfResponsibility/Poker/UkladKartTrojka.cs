namespace DesignPattern.Behavioral.ChainOfResponsibility.Poker
{
    class UkladKartTrojka : UkladKart
    {
        public override Uklad Uklad(RozdaneKarty karty)
        {
            if (WGrupie(3, karty))
            {
                return Poker.Uklad.Trojka;
            }

            return Nastepny.Uklad(karty);
        }
    }
}
