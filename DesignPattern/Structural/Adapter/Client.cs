namespace DesignPattern.Structural.Adapter
{
    public abstract class Client
    {
        private Target target;

        public Target Target { get => target; set => target = value; }
    }
}
