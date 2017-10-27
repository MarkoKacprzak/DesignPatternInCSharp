using System;

namespace DesignPattern.Behavioral.ChainOfResponsibility.Poker
{
    class Karta : IComparable<Karta>
    {
        public Karta(Kolor kolor, Figura figura)
        {
            Kolor = kolor;
            Figura = figura;
        }

        public Kolor Kolor
        {
            get;
        }

        public Figura Figura
        {
            get;
        }

        public override string ToString()
        => $"{FiguraToString()} {KolorToString()}";        

        private string KolorToString()
        {
            switch (Kolor)
            {
                case Kolor.Trefl:
                    return "Trefl";
                case Kolor.Kier:
                    return "Kier";
                case Kolor.Karo:
                    return "Karo";
                case Kolor.Pik:
                    return "Pik";
                default:
                    throw new NotImplementedException();
            }
        }

        private string FiguraToString()
        {
            switch (Figura)
            {
                case Figura.Dwojka:
                    return "2";
                case Figura.Trojka:
                    return "3";
                case Figura.Czworka:
                    return "4";
                case Figura.Piatka:
                    return "5";
                case Figura.Szostka:
                    return "6";
                case Figura.Siodemka:
                    return "7";
                case Figura.Osemka:
                    return "8";
                case Figura.Dziewiatka:
                    return "9";
                case Figura.Dziesiatka:
                    return "10";
                case Figura.Walet:
                    return "Walet";
                case Figura.Dama:
                    return "Dama";
                case Figura.Krol:
                    return "Krol";
                case Figura.As:
                    return "As";
                default:
                    throw new NotImplementedException();

            }
        }

        public int CompareTo(Karta other)
            => (int)Figura - (int)other.Figura;
    }
}
