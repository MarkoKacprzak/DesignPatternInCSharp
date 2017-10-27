﻿namespace DesignPattern.Behavioral.ChainOfResponsibility.Poker
{
    class UkladKartWysokaKarta : UkladKart
    {
        public override Uklad Uklad(RozdaneKarty hand)
        {
            return Poker.Uklad.WysokaKarta;
        }
    }
}
