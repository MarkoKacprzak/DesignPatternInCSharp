namespace DesignPattern.Behavioral.Observer
{
    /// <summary>
    /// MainApp startup class for Structural 
    /// Observer Design Pattern.
    /// </summary>
    public class Demo:IDemo
    {
        public string Name => "Observer pattern";
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        public void Run()
        {
            // Configure Observer pattern
            var s = new ConcreteSubject();

            s.Attach(new ConcreteObserver(s, "X"));
            s.Attach(new ConcreteObserver(s, "Y"));
            s.Attach(new ConcreteObserver(s, "Z"));

            // Change subject and notify observers
            s.SubjectState = "ABC";
            s.Notify();
        }
    }
}
