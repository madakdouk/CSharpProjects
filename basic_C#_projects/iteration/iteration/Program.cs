// See https://aka.ms/new-console-template for more information

/*** Part 1 ***/

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

/*** Part 2 ***/

//creating infinite loop
//for (int k = 0; k < greetings.Length; k++)
//{
//    //adding ! to end of each string
//    greetings[k] = greetings[k] + "!";
//    //decrementing counter so loop is infinite
//    k--;
//}

for (int k = 0; k < greetings.Length; k++)
{
    //adding ! to end of each string
    greetings[k] = greetings[k] + "!";
    //removed decrement code to fix infinite loop
}

/*** Part 3 ***/

//creating loop using < condition
for (int l = 0; l < greetings.Length; l++)
{
    //printing out greetings again, with the added exclamation mark
    Console.WriteLine("\n" + greetings[l]);
}

//creating loop using <= condition
for (int m = 0; m <= 4; m++)
{
    //adding another exclamation mark to each string
    greetings[m] = greetings[m] + "!";
}

Console.ReadLine();
