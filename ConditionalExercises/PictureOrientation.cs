using System;
namespace ConditionalExercises
{
    public class PictureOrientation
    {
        public static void Orientation()
        {
            Console.WriteLine("Picture Orientation Validator");
            Console.Write($"Enter the height of your image, please only include the number: ");
            var height = Console.ReadLine();
            Console.Write($"Enter the width of your image, please only include the number: ");
            var width = Console.ReadLine();

            int intHeight;
            int intWidth;

            try
            {
                intHeight = Int32.Parse(height);
                intWidth = Int32.Parse(width);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid numbers entered. Please run program again.");
                return;
            }

            if (intHeight > intWidth)
            {
                Console.WriteLine($"height:  {intHeight} width: {intWidth}");
                Console.WriteLine("The image is in portrait format");
            }
            else if (intWidth > intHeight)
            {
                Console.WriteLine($"height:  {intHeight} width: {intWidth}");
                Console.WriteLine("The image is in landscape format");
            }
            else
            {
                Console.WriteLine($"height:  {intHeight} width: {intWidth}");
                Console.WriteLine("The image is a square");
            }

        }
    }
}

