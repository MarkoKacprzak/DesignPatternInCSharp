using System.Collections.Generic;

namespace DesignPattern.Behavioral.Iterator
{
    /// <summary>
    /// The 'Iterator' abstract class
    /// </summary>
    public abstract class Iterator<T> where T : class
    {
        public abstract T First();
        public abstract T Next();
        public abstract bool IsDone();
        public abstract T CurrentItem();
    }
}
