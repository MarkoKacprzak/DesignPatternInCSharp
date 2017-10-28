using System.Collections.Generic;

namespace DesignPattern.Behavioral.Interpreter.Sandwich
{
    public class IngredientList : Expression
    {
        private readonly List<Ingredient> ingredients;

        public IngredientList(List<Ingredient> ingredients)
        {
            this.ingredients = ingredients;
        }

        public void Interpret(Context context)
        {
            foreach(var ingredient in ingredients)
                ingredient.Interpret(context);
        }
    }
}
