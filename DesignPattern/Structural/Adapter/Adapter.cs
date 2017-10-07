namespace DesignPattern.Structural.Adapter
{
    /// <summary>
    /// The 'Adapter' class
    /// </summary>
    public class Adapter : Target
    {
        private Adaptee _adaptee = new Adaptee();

        public override void Request()
        {
            // Possibly do some other work
            //  and then call SpecificRequest
            _adaptee.SpecificRequest();
        }
    }
}
