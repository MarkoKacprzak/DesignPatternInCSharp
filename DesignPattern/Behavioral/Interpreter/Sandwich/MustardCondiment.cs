namespace DesignPattern.Behavioral.Interpreter.Sandwich
{
    public class MustardCondiment : Condiment
    {
        public void Interpret(Context context)
        {
            context.Output += string.Format(" {0} ", "Mustard");
        }
    }
}
