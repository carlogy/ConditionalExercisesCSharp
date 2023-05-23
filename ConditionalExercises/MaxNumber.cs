using System;
namespace ConditionalExercises
{
    public class MaxNumber
    {

        public static void GetNumbers()
        {
            Console.Write("Enter a number: ");
            var inputOne = Console.ReadLine();
            Console.Write("Enter a second Number: ");
            var inputTwo = Console.ReadLine();

            try
            {
                int NumberOne = Int32.Parse(inputOne);
                int NumberTwo = Int32.Parse(inputTwo);

                if (NumberOne > NumberTwo)
                {
                    Console.WriteLine($"The max number is: {NumberOne}");
                }
                else if (NumberTwo > NumberOne)
                {
                    Console.WriteLine($"The max number is: {NumberTwo}");
                }
                else
                {
                    Console.WriteLine("The numbers are equal.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Unable to parse input");
            }


        }

    }
}