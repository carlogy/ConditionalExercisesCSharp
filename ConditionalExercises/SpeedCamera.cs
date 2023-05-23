using System;
namespace ConditionalExercises
{
    public class SpeedCamera
    {
        public static void SpeedCheck()
        {
            Console.Write("Enter the speed limit: ");
            var limit = Console.ReadLine();
            Console.Write("Enter the speed of car: ");
            var speed = Console.ReadLine();

            int speedLimit;
            int carSpeed;

            try
            {
                speedLimit = Int32.Parse(limit);
                carSpeed = Int32.Parse(speed);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number entered.");
                return;
            }



            int overSpeed = carSpeed - speedLimit;
            int numberDemerits = overSpeed / 5;




            //Console.WriteLine($"The car is over by {overSpeed}, conversion is {numberDemerits}");

            switch (numberDemerits)


            {
                case >= 12:
                    Console.WriteLine("Suspend drivers liscence!");
                    break;
                case > 0:
                    Console.WriteLine($"Driver has accumulated {numberDemerits} demerits.");
                    break;

                default:
                    Console.WriteLine("The driver is respecting speed limit.");
                    break;
            }

            Console.ReadLine();



        }
    }
}

