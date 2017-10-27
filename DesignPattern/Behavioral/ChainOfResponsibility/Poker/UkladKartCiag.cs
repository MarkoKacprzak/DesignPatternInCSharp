namespace DesignPattern.Behavioral.ChainOfResponsibility.Poker
{
    class UkladKartCiag
    {
        private UkladKartCiag()
        {
            Start = new UkladKartPokerKrolewski();
            Start.ZarejestrujNastepny(new UkladKartPoker())
                 .ZarejestrujNastepny(new UkladKartKareta())
                 .ZarejestrujNastepny(new UkladKartFull())
                 .ZarejestrujNastepny(new UkladKartKolor())
                 .ZarejestrujNastepny(new UkladKartStrit())
                 .ZarejestrujNastepny(new UkladKartTrojka())
                 .ZarejestrujNastepny(new UkladKartDwiePary())
                 .ZarejestrujNastepny(new UkladKartPara())
                 .ZarejestrujNastepny(new UkladKartWysokaKarta());
        }

        public static Uklad ZnajdzUklad(RozdaneKarty hand)
        {
            return _instance.Start.Uklad(hand);
        }

        private UkladKart Start { get; set; }

        private static readonly UkladKartCiag _instance = new UkladKartCiag();
    }
}
