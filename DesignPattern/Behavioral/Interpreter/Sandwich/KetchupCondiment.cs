namespace DesignPattern.Behavioral.Interpreter.Sandwich
{
    public class KetchupCondiment : Condiment
    {
        public void Interpret(Context context)
        {
            context.Output += string.Format(" {0} ", "Ketchup");
        }
    }
}
