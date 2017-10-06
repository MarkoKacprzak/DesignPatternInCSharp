using System;
namespace DesignPattern.Behavioral.Command
{
    public class Light
    {
        private bool isOn = false;
        private const int Receiver = 1;

        public bool IsOn => isOn;
        public void Toggle()
        {
            if (IsOn)
            {
                Off();
                isOn = false;
            }
            else
            {
                On();
                isOn = true;
            }
        }
        public void On()
        {
           Console.WriteLine("Light switched on.");
        }
        public void Off()
        {
            Console.WriteLine("Light switched off.");
        }
    }
}
