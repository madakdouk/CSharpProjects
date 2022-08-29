namespace callingMethods
{
    public class Program
    {
        static void Main(string[] args)
        {
            //asking user for input
            Console.WriteLine("Please input a number. It will be used in 3 different calculations.");
            //storing input in var
            int n = Convert.ToInt32(Console.ReadLine());

            //calling methods
            Console.WriteLine(n + " + 5 = " + Methods.Add5(n) + "\n" + n + " * 2 = " + Methods.Times2(n) + "\n" + n + " - 3 = " + Methods.Minus3(n));
            Console.Read();

            //can be improved by adding code to catch non-integer input
        }
    }
}