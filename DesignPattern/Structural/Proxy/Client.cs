using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Structural.Proxy
{
    public class Client
    {
        private Subject subject;

        public Subject Subject { get => subject; set => subject = value; }
    }
}
