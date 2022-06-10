using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var firstDate = Console.ReadLine();
            var secondDate = Console.ReadLine();

            DateModifier dateModifier = new DateModifier();

            var total = dateModifier.CalculateDiffereceBetwwenDates(firstDate, secondDate);

            Console.WriteLine(total);
        }
    }
}
