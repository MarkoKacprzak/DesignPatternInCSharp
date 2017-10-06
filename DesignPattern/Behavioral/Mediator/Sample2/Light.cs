using System;

namespace DesignPattern.Behavioral.Mediator.Sample2
{
    public class Light
    {
        private bool isOn = false;
        private readonly string location;
        public Light(string location)
        {
            this.location = location;
        }
        public bool IsOn => isOn;
        public void Toggle()
        {
            if (isOn)
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
        public void On() =>        
            Console.WriteLine($"{location} Light switched on.");
        public void Off() =>        
            Console.WriteLine($"{location} Light switched off.");
    }
}
