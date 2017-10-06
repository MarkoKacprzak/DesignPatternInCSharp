using System;

namespace DesignPattern.Behavioral.Memento
{
    /// <summary>
    /// The 'Originator' class
    /// </summary>
    public class Originator
    {
        private string _state;
        // Property
        public string State
        {
            get { return _state; }
            set
            {
                _state = value;
                Console.WriteLine($"State = {_state}");
            }
        }

        // Creates memento 
        public Memento Memento
        {
            get
            {
                return (new Memento(_state));
            }
        }
        public Memento CreateMemento()
        {
            return (new Memento(_state));
        }

        // Restores original state
        public void SetMemento(Memento memento)
        {
            Console.WriteLine("Restoring state...");
            State = memento.State;
        }
    }
}
