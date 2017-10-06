namespace DesignPattern.Behavioral.Interpreter
{
    public abstract class Client
    {
        private Expression expression;
        private Context context;

        public Expression Expression { get => expression; set => expression = value; }
        public Context Context { get => context; set => context = value; }
    }
}
