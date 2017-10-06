namespace DesignPattern.Behavioral.Mediator
{
    /// <summary>
    /// Mediator Design Pattern.
    /// </summary>
    public class Demo:IDemo
    {
        public string Name => "Mediator pattern";
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        public void Run()
        {
            var m = new ConcreteMediator();

            var c1 = new ConcreteColleague1(m);
            var c2 = new ConcreteColleague2(m);

            m.Colleague1 = c1;
            m.Colleague2 = c2;

            c1.Send("How are you?");
            c2.Send("Fine, thanks");            
        }
    }
}
