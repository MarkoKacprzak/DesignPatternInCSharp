namespace DesignPattern.Behavioral.ChainOfResponsibility.Sample
{
    public class Client
    {
        private Handler handler;

        public Handler Handler { get => handler; set => handler = value; }
    }
}
