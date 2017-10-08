namespace DesignPattern.Structural.Proxy
{
    /// <summary>
    /// The 'Proxy' class
    /// </summary>
    public class Proxy : Subject
    {
        private RealSubject _realSubject;

        public override void Request()
        {
            // Use 'lazy initialization'
            if (_realSubject == null)
            {
                _realSubject = new RealSubject();
            }

            _realSubject.Request();
        }
    }
}
