using System.Linq;
using System.Text;

namespace DesignPattern.Behavioral.Interpreter.Sandwich
{
    public interface Expression
    {
        void Interpret(Context context);
    }
}
