namespace DesignPattern.Behavioral.Observer
{
    /// <summary>
    /// The 'ConcreteSubject' class
    /// </summary>
    public class ConcreteSubject : Subject
    {
        private string _subjectState;
        // Gets or sets subject state
        public string SubjectState
        {
            get { return _subjectState; }
            set { _subjectState = value; }
        }
    }
}
