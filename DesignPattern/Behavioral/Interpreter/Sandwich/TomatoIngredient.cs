namespace DesignPattern.Behavioral.Interpreter.Sandwich
{
    public class TomatoIngredient : Ingredient
    {
        public void Interpret(Context context)
        {
            context.Output += string.Format(" {0} ", "Tomato");
        }
    }
}
