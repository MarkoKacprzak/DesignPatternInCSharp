using System;

namespace DesignPattern.Behavioral.Interpreter
{
    public abstract class Expression
    {
        public abstract bool Interpret(String context);
    }
}
