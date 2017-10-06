using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Behavioral.Iterator
{
    public class Demo:IDemo
    {
        public string Name => "Iterator pattern";
        public void Run()
        {
            var a = new ConcreteAggregate<string>();
            a[0] = "Item A";
            a[1] = "Item B";
            a[2] = "Item C";
            a[3] = "Item D";

            // Create Iterator and provide aggregate
            var i = a.CreateIterator();
            Console.WriteLine("Iterating over collection:");

            var item = i.First();
            while (item != null)
            {
                Console.WriteLine(item);
                item = i.Next();
            }
            if (i.IsDone())
                item = i.First();
            while (item != null)
            {
                Console.WriteLine(item);
                item = i.Next();
            }

        }
    }
}
