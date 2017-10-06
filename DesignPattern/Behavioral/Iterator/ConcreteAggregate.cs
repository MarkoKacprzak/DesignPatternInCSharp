using System.Collections;
using System.Collections.Generic;

namespace DesignPattern.Behavioral.Iterator
{
    /// <summary>
    /// The 'ConcreteAggregate' class
    /// </summary>
    public class ConcreteAggregate<T> : Aggregate<T> where T : class
    {
        private List<T> _items = new List<T>();

        public override Iterator<T> CreateIterator()=>
            new ConcreteIterator<T>(this);        
        // Gets item count
        public int Count => _items.Count;        
        // Indexer
        public T this[int index]
        {
            get { return _items[index]; }
            set { _items.Insert(index, value); }
        }
    }
}
