using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Creational.Prototype
{
    class Client
    {
        private Prototype prototype;

        public Prototype Prototype { get => prototype; set => prototype = value; }
    }
}
