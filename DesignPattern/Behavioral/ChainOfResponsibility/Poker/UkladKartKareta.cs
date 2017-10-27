namespace DesignPattern.Behavioral.ChainOfResponsibility.Poker
{
    class UkladKartKareta : UkladKart
    {
        public override Uklad Uklad(RozdaneKarty karty)
        {
            if (WGrupie(4, karty))
            {
                return Poker.Uklad.Kareta;
            }

            return Nastepny.Uklad(karty);
        }
    }
}
