namespace DesignPattern.Behavioral.Interpreter.Sandwich
{
    public class MayoCondiment : Condiment
    {
        public void Interpret(Context context)
        {
            context.Output += string.Format(" {0} ", "Mayo");
        }
    }
}
