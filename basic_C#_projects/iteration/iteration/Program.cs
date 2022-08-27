// See https://aka.ms/new-console-template for more information

/***Part 1***/
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
Console.WriteLine("We will print out several greetings for you.\n");
//creating loop to print each element from array
for (int j = 0; j < greetings.Length; j++)
{
    //printing each element
    Console.WriteLine(greetings[j]);
}

/***Part 2***/
//creating infinite loop
//for (int k = 0; k < greetings.Length; k++)
//{
//    //adding ! to end of each string
//    greetings[k] = greetings[k] + "!";
//    //decrementing counter so loop is infinite
//    k--;
//}
Console.WriteLine("\nNow we will add ! to the end of each greeting.\n");
for (int k = 0; k < greetings.Length; k++)
{
    //removed decrement instruction to fix infinite loop
    greetings[k] = greetings[k] + "!";
   
}

/***Part 3***/
//creating loop using < condition
for (int l = 0; l < greetings.Length; l++)
{
    //printing out greetings again, with the added exclamation mark
    Console.WriteLine(greetings[l]);
}
//creating loop using <= condition
for (int m = 0; m <= greetings.Length - 1; m++)
{
    //adding another exclamation mark to each string
    greetings[m] = greetings[m] + "!";
}

/***Part 4***/
//creating list with unique elements
List<string> colors = new List<string>() { "red", "yellow", "blue" };
//asking for user input to search through list
Console.WriteLine("\nPlease type in one of the following to search for it in the list: \"blue\", \"red\", or \"yellow\"");
//creating variable to store user input
string color = Console.ReadLine();
//checking if input is contained within list
if (colors.Contains(color))
{
    //if input is valid, start for loop
    for (int i = 0; i < colors.Count; i++)
    {
        //check if input matches at each index of list
        if (colors[i] == color)
        {
            //once match is found, print results
            Console.WriteLine(color + " is found at index " + i + "");
            //exit loop once match is found
            break;
        }
    }
}
//if input is not contained within the list
else
{
    Console.WriteLine(color + " is not contained within the list.");
}

/***Part 5***/
//creating list with 2 identical strings
List<string> pets = new List<string>() { "dog", "cat", "fish", "hamster", "dog", "iguana", "cat", "cat", "bird", "dog" };
//asking for user input
Console.WriteLine("\nPlease type in the name of a pet to search for it in the list.");
string pet = Console.ReadLine();
//checking if input is contained within list
if (pets.Contains(pet))
{
    //declaring new list to store indices
    List<int> indices = new List<int>();
    //if input is valid, start for loop
    for (int i = 0; i < pets.Count; i++)
    {
        //check if input matches at each index of list
        if (pets[i] == pet)
        {
            //adding matches to indices list
            indices.Add(i);
        }
    }
    //displaying indices that input is found at
    Console.WriteLine(string.Format(pet + " is found at the following indices: {0}.", string.Join(", ", indices)));
}
//if input is not contained within the list
else
{
    Console.WriteLine(pet + " is not contained within the list.");
}

/***Part 6***/
//creating list with 2 identical strings
List<string> pets2 = new List<string>() { "cat", "snake", "mouse", "turtle", "cat", "dog", "fish" };
//creating another list to be compared to
List<string> pets2_ = new List<string>();
//creating for each loop
foreach (string pet2 in pets2)
{
    if (pets2_.Contains(pet2))
    {
        //if the item is already in second list, it is a duplicate
        Console.WriteLine(pet2 + " - this item is a duplicate.");
    }
    else
    {
        //otherwise, add the item to the second list and display it as unique
        pets2_.Add(pet2);
        Console.WriteLine(pet2 + " - this item is unique.");
    }
}
Console.Read();