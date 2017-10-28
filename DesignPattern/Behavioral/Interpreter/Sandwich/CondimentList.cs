using System.Collections.Generic;

namespace DesignPattern.Behavioral.Interpreter.Sandwich
{
    public class CondimentList : Expression
    {
        private readonly List<Condiment> condiments;

        public CondimentList(List<Condiment> condiments )
        {
            this.condiments = condiments;
        }

        public void Interpret(Context context)
        {
            foreach(var condiment in condiments)
                condiment.Interpret(context);
        }
    }
}
