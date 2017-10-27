namespace DesignPattern.Behavioral.ChainOfResponsibility.Poker
{
    class UkladKartWysokaKarta : UkladKart
    {
        public override Uklad Uklad(RozdaneKarty karty)
        {
            return Poker.Uklad.WysokaKarta;
        }
    }
}
