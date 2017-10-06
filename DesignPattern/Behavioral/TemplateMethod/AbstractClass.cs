using System;

namespace DesignPattern.Behavioral.TemplateMethod
{
    /// <summary>
    /// The 'AbstractClass' abstract class
    /// </summary>
    public abstract class AbstractClass
    {
        public abstract void SubMethod1();
        public abstract void SubMethod2();

        // The "Template method"
        public void TemplateMethod()
        {
            SubMethod1();
            SubMethod2();
            Console.WriteLine("");
        }
    }
}
