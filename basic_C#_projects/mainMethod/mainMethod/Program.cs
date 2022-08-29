namespace mainMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //passing integer to first method and displaying result
            Console.WriteLine("1 + 1 = " + methods.one(1));

            //passing float to second method and displaying result
            Console.WriteLine("11.5 / 2 = " + methods.one(11.5f));

            //passing string to third method and displaying result
            Console.WriteLine("10 - 3 = " + methods.one("10"));

            Console.Read();
        }
    }
}