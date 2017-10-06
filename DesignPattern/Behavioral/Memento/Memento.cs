namespace DesignPattern.Behavioral.Memento
{
    /// <summary>
    /// The 'Memento' class
    /// </summary>
    public class Memento
    {
        private string _state;
        // Constructor
        public Memento(string state)
        {
            this._state = state;
        }
        // Gets or sets state
        public string State => _state;        
    }
}
