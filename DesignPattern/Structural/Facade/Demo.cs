using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Structural.Facade
{
    /// <summary>
    /// MainApp startup class for Structural
    /// Facade Design Pattern.
    /// </summary>
    public class Demo:IDemo
    {
        public string Name => "Facade pattern";

        /// <summary>
        /// Entry point into console application.
        /// </summary>
        public void Run()
        {
            var facade = new Facade();

            facade.MethodA();
            facade.MethodB();
        }
    }

    /// <summary>
    /// The 'Subsystem ClassA' class
    /// </summary>
    public class SubSystemOne
    {
        public void MethodOne()
        {
            Console.WriteLine(" SubSystemOne Method");
        }
    }
}
