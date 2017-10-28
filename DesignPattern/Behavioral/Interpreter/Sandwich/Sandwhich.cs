using System;

namespace DesignPattern.Behavioral.Interpreter.Sandwich
{
    /// <summary>
    /// BNF:
    /// <sandwhich> ::= <bread> <condimentList> <ingredientList> <condimentList> <bread>
    /// <condimentList> ::= { <condiment> }
    /// <ingredientList> ::= { <ingredient> }
    /// <bread> ::= <whiteBread> | <wheatBread>
    /// <condiment> ::= <mayoCondiment> | <mustardCondiment> | <ketchupCondiment>
    /// <ingredient> ::= <lettuceIngredient> | <tomatoIngredient> | <chickenIngredient>
    /// </summary>
    public class Sandwhich : Expression
    {
        private readonly Bread topBread;
        private readonly CondimentList topCondiments;
        private readonly IngredientList ingredients;
        private readonly CondimentList bottomCondiments;
        private readonly Bread bottomBread;

        public Sandwhich(Bread topBread, CondimentList topCondiments, IngredientList ingredients, CondimentList bottomCondiments, Bread bottomBread)
        {
            this.topBread = topBread;
            this.topCondiments = topCondiments;
            this.ingredients = ingredients;
            this.bottomCondiments = bottomCondiments;
            this.bottomBread = bottomBread;
        }

        public void Interpret(Context context)
        {
            context.Output += "|";
            topBread.Interpret(context);
            context.Output += "|";
            context.Output += "<--";
            topCondiments.Interpret(context);
            context.Output += "-";
            ingredients.Interpret(context);
            context.Output += "-";
            bottomCondiments.Interpret(context);
            context.Output += "-->";
            context.Output += "|";
            bottomBread.Interpret(context);
            context.Output += "|";
            Console.WriteLine(context.Output);
        }
    }
}
