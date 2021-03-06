﻿using DesignPattern.Behavioral.Memento.Paint;
using System;

namespace DesignPattern
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Get.Run("Behavioral");
            //Get.All("DesignPattern.Behavioral").Run();
            //Behavioral.Patterns.All.Run();
            Get.Run("Structural");
            //Get.All("DesignPattern.Structural").Run();
            //Structural.Patterns.All.Run();
            Get.Run("Creational");
            //Get.All("DesignPattern.Creational").Run();
            //Creational.Patterns.All.Run();
            Get.Sample("Behavioral");
            Get.Sample("Creational");
            Mix.Houses.Program.Run();
            Mix.Reservations.Program.Run();
            Mix.Family.TextDemo.Program.Run();
            Mix.CarShop.Program.Run();
            Mix.Appointments.Program.Run();
            Mix.CalculateControlDigit.Program.Run();
            Mix.Iterator.Program.Run();
            Mix.NTierApp.Program.Run();
        }
    }
}
