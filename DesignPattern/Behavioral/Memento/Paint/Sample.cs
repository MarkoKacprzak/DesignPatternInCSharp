using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DesignPattern.Behavioral.Memento.Paint
{
    public class Sample : ISample
    {
        [STAThread]
        public void Run()
        {
                var app = new App();
                app.Run(new MainWindow());   
        }
    }
}
