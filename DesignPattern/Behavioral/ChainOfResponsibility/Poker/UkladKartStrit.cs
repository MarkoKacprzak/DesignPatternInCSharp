namespace DesignPattern.Behavioral.ChainOfResponsibility.Poker
{
    class UkladKartStrit : UkladKart
    {
        public override Uklad Uklad(RozdaneKarty karty)
        {
            if (WStricie(karty))
            {
                return Poker.Uklad.Strit;
            }

            return Nastepny.Uklad(karty);
        }
    }
}
