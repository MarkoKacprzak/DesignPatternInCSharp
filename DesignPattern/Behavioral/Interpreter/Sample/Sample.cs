using System;
using System.Collections.Generic;

namespace DesignPattern.Behavioral.Interpreter.Sample
{
    /// <summary>
    /// MainApp startup class for Real-World 
    /// Interpreter Design Pattern.
    /// </summary>
    public class Sample:ISample
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        public void Run()
        {
            string roman = "MCMXXVIII";
            Context context = new Context(roman);

            // Build the 'parse tree'
            var tree = new List<Expression>
            {
                new ThousandExpression(),
                new HundredExpression(),
                new TenExpression(),
                new OneExpression()
            };

            // Interpret
            foreach (var exp in tree)
            {
                exp.Interpret(context);
            }

            Console.WriteLine($"{roman} = {context.Output}");
        }
    }
}
