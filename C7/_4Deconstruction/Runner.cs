using static System.Console;

namespace C7._4Deconstruction
{
    public class Runner: IRunner, IRunner2
    {
    public void Run()
    {
      (int hour, int minutes, int seconds) = GetTime();

      if (minutes > 30)
      {
        hour++;
      }

      WriteLine($"{hour}:{minutes}:{seconds}");

    }

    public (int, int, int) GetTime()
    {
      return (1, 35, 40);
    }

    public void Run2()
    {
      int hour;
      int minutes;
      int seconds;
      (hour, minutes, seconds) = GetTime();
      WriteLine($"The time using local variables: {hour}:{minutes}:{seconds}");
    }
  }
}
