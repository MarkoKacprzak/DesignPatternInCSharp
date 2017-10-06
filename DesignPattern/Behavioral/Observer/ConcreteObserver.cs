using System;

namespace DesignPattern.Behavioral.Observer
{
    /// <summary>
    /// The 'ConcreteObserver' class
    /// </summary>
    public class ConcreteObserver : Observer
    {
        private string _name;
        private string _observerState;
        private ConcreteSubject _subject;
        // Constructor
        public ConcreteObserver(ConcreteSubject subject, 
            string name)
        {
            this._subject = subject;
            this._name = name;
        }
        public override void Update()
        {
            _observerState = _subject.SubjectState;
            Console.WriteLine($"Observer {_name}'s " +
                $"new state is {_observerState}");
        }
        // Gets or sets subject
        public ConcreteSubject Observes
        {
            get { return _subject; }
            set { _subject = value; }
        }
    }
}
