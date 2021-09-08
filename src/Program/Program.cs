using System;

namespace UnitTestAndDebug
{
    class Program
    {
        static void Main(string[] args)
        {
            Person john = new Person("John Doe", "1.234.567-2", "24/12/2000");
            Person jane = new Person("Jane Doe", "8.765.432-1", "8/13/1988");
            john.IntroduceYourself();
            jane.IntroduceYourself();
        }
    }
}
