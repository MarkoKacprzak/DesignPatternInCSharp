using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Creational.Builder
{
    /// <summary>
    /// MainApp startup class for Structural
    /// Builder Design Pattern.
    /// </summary>
    public class Demo:IDemo
    {
        public string Name => "Builder pattern";

        /// <summary>
        /// Entry point into console application.
        /// </summary>
        public void Run()
        {
            // Create director and builders
            var director = new Director();

            var b1 = new ConcreteBuilder1();
            var b2 = new ConcreteBuilder2();

            // Construct two products
            director.Construct(b1);
            var p1 = b1.GetResult();
            p1.Show();

            director.Construct(b2);
            var p2 = b2.GetResult();
            p2.Show();
        }
    }
}
