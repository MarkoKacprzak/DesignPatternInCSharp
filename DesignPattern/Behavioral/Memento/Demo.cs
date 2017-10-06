using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Behavioral.Memento
{
    /// <summary>
    /// MainApp startup class for Structural 
    /// Memento Design Pattern.
    /// </summary>
    public class Demo : IDemo
    {
        public string Name => "Memento pattern";
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        public void Run()
        {
            var o = new Originator
            {
                State = "On"
            };
            // Store internal state
            var c = new Caretaker
            {
                Memento = o.CreateMemento()
            };
            // Continue changing originator
            o.State = "Off";
            // Restore saved state
            o.SetMemento(c.Memento);
        }
    }
}
