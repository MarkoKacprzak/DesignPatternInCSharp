using System;
using static System.Console;

namespace C7._7Enhancements
{
    public class Runner:IRunner
  {
    public void Run()
    {
      WriteLine(GetBigNumber());
      int[] numbers = { 2, 7, 1, 9, 12, 8, 15 };
      ref int position = ref Substitute(12, numbers);
      position = -12;
      WriteLine(numbers[4]);

      var joe = new Employee("Manager");
      WriteLine(joe.Position);

     // var mary = new Employee(null);
    //  WriteLine(mary.Position);
    }

    public int GetBigNumber()
    {
      return 1_234_567;
    }

    public ref int Substitute(int value, int[] numbers)
    {
      for (int i = 0; i < numbers.Length; i++)
      {
        if (numbers[i] == value)
        {
          return ref numbers[i];
        }
      }
      throw new IndexOutOfRangeException("Not found!");
    }
  }
}
