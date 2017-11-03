using static System.Console;

namespace C7._3Parameters
{
    public class Runner: IRunner
    {
    public void Run()
    {
      PrintSum(10);
      PrintSum2("10");
    }

    public void PrintSum(object o)
    {
      if (o is null) return;  // constant pattern
      if (!(o is int i)) return; // type pattern (int)

      int sum = 0;
      for (int j = 0; j <= i; j++)
      {
        sum += j;
      }

      WriteLine($"The sum of 1 to {i} is {sum}");
    }

    public void PrintSum2(object o)
    {
      if (o is int i || o is string s && int.TryParse(s, out i))
      {
        int sum = 0;
        for (int j = 0; j <= i; j++)
        {
          sum += j;
        }

        WriteLine($"The sum of 1 to {i} is {sum}");
      }
    }
  }
}
