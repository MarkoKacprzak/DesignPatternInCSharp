using System;
using System.Collections.Generic;

namespace DesignPattern.Creational.Builder.Sample
{
    /// <summary>
    /// The 'Product' class
    /// </summary>
    public class Vehicle
    {
        private string _vehicleType;
        private Dictionary<string, string> _parts=new Dictionary<string, string>();

        // Constructor
        public Vehicle(string vehicleType)
        {
            _vehicleType = vehicleType;
        }

        // Indexer
        public string this[string key]
        {
            get { return _parts[key]; }
            set { _parts[key] = value; }
        }

        public void Show()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine($"Vehicle Type: {_vehicleType}");
            Console.WriteLine($" Frame : {_parts["frame"]}");
            Console.WriteLine($" Engine : {_parts["engine"]}");
            Console.WriteLine($" #Wheels: {_parts["wheels"]}");
            Console.WriteLine($" #Doors : {_parts["doors"]}");
        }
    }
}
