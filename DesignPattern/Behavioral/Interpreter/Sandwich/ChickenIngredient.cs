namespace DesignPattern.Behavioral.Interpreter.Sandwich
{
    public class ChickenIngredient : Ingredient
    {
        public void Interpret(Context context)
        {
            context.Output += string.Format(" {0} ", "Chicken");
        }
    }
}
