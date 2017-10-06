using System;

namespace DesignPattern.Behavioral.Interpreter
{
    public class Demo : IDemo
    {
        public string Name => "Interpreter pattern";

        static Expression BuildInterpreterTree()
        {
            var terminal1 = new TerminalExpression("Lions");
            var terminal2 = new TerminalExpression("Tigers");
            var terminal3 = new TerminalExpression("Bears");
            // Tigers and Bears
            var alternation1 = new AndExpression(terminal2, terminal3);
            //Lions or (Tigers and Bears)
            var alternation2 = new OrExpression(terminal1, alternation1);
            return new AndExpression(terminal3, alternation2);
        }
        public void Run()
        {
            //var context = "Lions";
            //var context = "Tigers";
            //var context = "Bears";
            //var context = "Lions Tigers";
            //var context = "Lions Bears";
            var context = "Tigers Bears";
            Expression define = BuildInterpreterTree();
            Console.WriteLine($"{context} is {define.Interpret(context)}");
        }
    }
}
