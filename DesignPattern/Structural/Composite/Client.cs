using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Structural.Composite
{
    public class Client
    {
        Component component;

        public Component Component { get => component; set => component = value; }
    }
}
