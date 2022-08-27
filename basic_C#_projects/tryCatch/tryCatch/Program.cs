namespace tryCatch
{
    internal class Program
    {
        static void Main()
        {
            //creating list of integers
            List<int> integers = new List<int> { 40, 72, 15, 96 };
            //bool to use in do while loop
            bool valid = false;
            //asking for user to input a number
            Console.WriteLine("I have a list of integers. Please input a number to divide each integer by.");

            //using a do while loop so that program will repeat until user enters appropriate input
            do
            {
                //try catch block will prevent program from unexpectingly closing due to invalid input
                try
                {
                    //if input is valid, set variable equal to user input
                    int divide = Convert.ToInt32(Console.ReadLine());
                    //use for loop to iterate through integer list
                    for (int i = 0; i < integers.Count; i++)
                    {
                        //divide integer at current indiex by user input and store result
                        int quotient = integers[i] / divide;
                        //print results for user
                        Console.WriteLine(integers[i] + " divided by " + divide + " equals " + quotient);
                        //change bool value so that loop will end
                        valid = true;
                    }
                }
                //catch error if user inputs string
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                //catch error if user inputs 0
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            while (!valid);
            //print message to thank user/verify that program exited try-catch block
            Console.WriteLine("\nThank you for using this program!");
        }
    }
}