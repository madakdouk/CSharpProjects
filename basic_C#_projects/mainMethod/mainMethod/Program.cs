namespace mainMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //instantiating the class
            methods method = new methods();

            //passing integer to first method and displaying result
            Console.WriteLine("1 + 1 = " + method.one(1));

            //passing decimal to second method and displaying result
            Console.WriteLine("11.5 / 2 = " + method.one(11.5m));

            //passing string to third method and displaying result
            Console.WriteLine("10 - 3 = " + method.one("10"));

            Console.Read();
        }
    }
}