// See https://aka.ms/new-console-template for more information

//creating array of strings
string[] greetings = { "Hello, ", "Hi, ", "Hey, ", "Howdy, ", "Greetings, " };

//asking user for text input and storing it as variable
Console.WriteLine("Please type your name below.");
string name = Console.ReadLine();

//creating loop to add text input to each greeting
for (int i = 0; i < greetings.Length; i++)
{
    //concatenating strings
    greetings[i] = greetings[i] + name;
}

//creating loop to print each element from array
for (int j = 0; j < greetings.Length; j++)
{
    //printing each element
    Console.WriteLine("\n" + greetings[j]);
}

Console.ReadLine();
