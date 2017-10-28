namespace DesignPattern.Behavioral.Interpreter.Sandwich
{
    public class WhiteBread : Bread
    {
        public void Interpret(Context context)
        {
            context.Output += string.Format(" {0} ", "White-Bread");
        }
    }
}
