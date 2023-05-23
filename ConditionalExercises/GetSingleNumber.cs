using System;
namespace ConditionalExercises
{
    public class GetSingleNumber
    {
        public static void GetANumber()
        {
            Console.Write("Enter a number between 1 and 10: ");
            var firstInput = Console.ReadLine();

            try
            {
                int inputOne = Int32.Parse(firstInput);
                if (inputOne > 10)
                {
                    Console.WriteLine("Invalid");
                }
                else
                {
                    Console.WriteLine("Valid");
                }


            }
            catch (FormatException)
            {
                Console.WriteLine($"Unable to parse '{firstInput}', please enter a number between 1 and 10.");

            }
        }
    }
}