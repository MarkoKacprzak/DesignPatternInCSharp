namespace DesignPattern.Behavioral.Memento.Sample
{
    /// <summary>
    /// MainApp startup class for Real-World 
    /// Memento Design Pattern.
    /// </summary>
    public class Sample:ISample
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        public void Run()
        {
            var s = new SalesProspect
            {
                Name = "Noel van Halen",
                Phone = "(412) 256-0990",
                Budget = 25000.0
            };

            // Store internal state
            var m = new ProspectMemory
            {
                Memento = s.SaveMemento()
            };

            // Continue changing originator
            s.Name = "Leo Welch";
            s.Phone = "(310) 209-7111";
            s.Budget = 1000000.0;

            // Restore saved state
            s.RestoreMemento(m.Memento);
        }
    }
}
