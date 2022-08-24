using System;

namespace shippingQuote
{
    internal class Program
    {
        static void Main()
        {
            //displaying introduction message
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.\n");

            //getting user input for package weight and storing it as a variable
            //conversion from string to byte done on same line
            Console.WriteLine("What is the package weight? Please enter using numeric symbols.");
            byte pkgWeight = Convert.ToByte(Console.ReadLine());

            //check if weight is greater than 50
            if (pkgWeight > 50)
            {
                //print message if greater than 50
                Console.WriteLine("\nPackage too heavy to be shipped via Package Express. Have a good day.");
                //leave application open until user exits or presses a key
                Console.ReadLine();
                //exit application
                return;
            }

            //getting user input for package width and storing it as a variable
            //conversion from string to byte done on same line
            Console.WriteLine("\nWhat is the package width? Please enter using numeric symbols.");
            byte pkgWidth = Convert.ToByte(Console.ReadLine());

            //getting user input for package height and storing it as a variable
            //conversion from string to byte done on same line
            Console.WriteLine("\nWhat is the package height? Please enter using numeric symbols.");
            byte pkgHeight = Convert.ToByte(Console.ReadLine());

            //getting user input for package length and storing it as a variable
            //conversion from string to byte done on same line
            Console.WriteLine("\nWhat is the package length? Please enter using numeric symbols.");
            byte pkgLength = Convert.ToByte(Console.ReadLine());

            //calculating sum of dimensions
            int dimensionsSum = pkgWidth + pkgLength + pkgHeight;

            //check if dimensions is greater than 50
            if (dimensionsSum > 50)
            {
                //print message if greater than 50
                Console.WriteLine("\nPackage too large to be shipped via Package Express. Have a good day.");
                //leave application open until user exits or presses a key
                Console.ReadLine();
                //exit application
                return;
            }

            //calculating quote
            decimal quote = (pkgWidth * pkgLength * pkgHeight) * pkgWeight / 100;
            //displaying quote
            Console.WriteLine("\nYour estimated total for shipping this package is: $" + quote + "\nThank you!");
            Console.ReadLine();
        }
    }
}
