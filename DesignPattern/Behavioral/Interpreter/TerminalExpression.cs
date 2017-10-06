using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPattern.Behavioral.Interpreter
{
    public class TerminalExpression : Expression
    {
        private string data;
        public TerminalExpression(string data)
        {
            this.data = data;
        }
        public override bool Interpret(string context)
        {
            var words = new List<string>(context.Trim('\n', '\r').Split(' ').
                    Select(x => new string(x.Where(Char.IsLetterOrDigit).ToArray())));
            return words.Any(word => word.Equals(data));
        }
    }
}
