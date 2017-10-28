namespace DesignPattern.Behavioral.Interpreter.Sandwich
{
    public class LettuceIngredient : Ingredient
    {
        public void Interpret(Context context)
        {
            context.Output += string.Format(" {0} ", "Lettuce");
        }
    }
}
