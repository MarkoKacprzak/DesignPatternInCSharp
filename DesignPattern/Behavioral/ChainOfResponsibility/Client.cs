namespace DesignPattern.Behavioral.ChainOfResponsibility
{
    public class Client
    {
        private Handler handler;

        internal Handler Handler { get => handler; set => handler = value; }
    }
}
