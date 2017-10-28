﻿using System;

namespace DesignPattern.Behavioral.Command.Logging
{
    public class Program1
    {
        public static void Run(string[] args)
        {
            if (args.Length == 0)
            {
                PrintUsage();
                return;
            }
            var processor = new CommandExecutor();
            processor.ExecuteCommand(args);
        }

        private static void PrintUsage()
        {
            Console.WriteLine("Usage: App CommandName Arguments");
            Console.WriteLine("Commands:");
            Console.WriteLine("   UpdateQuantity number");
            Console.WriteLine("   CreateOrder");
            Console.WriteLine("   ShipOrder");
        }
    }
}
