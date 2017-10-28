namespace DesignPattern.Behavioral.Interpreter.Sandwich
{
    public class WheatBread : Bread
    {
        public void Interpret(Context context)
        {
            context.Output += string.Format(" {0} ", "Wheat-Bread");
        }
    }
}
