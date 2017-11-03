using System;

namespace C7._7Enhancements
{
    public class Employee
    {
        public string Position { get; }
        public Employee(string position) =>
          Position = position ?? throw new ArgumentNullException();
    }
}
