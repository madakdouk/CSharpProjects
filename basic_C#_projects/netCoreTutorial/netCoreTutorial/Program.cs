// See https://aka.ms/new-console-template for more information
Console.WriteLine("Please enter your first name.");
string name = Console.ReadLine();
string date = DateTime.Today.ToShortDateString();
string msg = $"\nWelcome back, {name}. Today is {date}.";
Console.WriteLine(msg);
string filePath = @"C:\Users\MDakd\OneDrive\Documents\GitHub\CSharpProjects\basic_C#_projects\netCoreTutorial\netCoreTutorial\scores.txt";
string[] lines = System.IO.File.ReadAllLines(filePath);
double total = 0.0;
Console.WriteLine("\nStudent Scores: \n");
foreach (string line in lines)
{
    Console.WriteLine(line);
    double score = Convert.ToDouble(line);
    total += score;
}
double avg = total / lines.Length;
Console.WriteLine("\nAverage: " + avg);
Console.WriteLine("\nPress any key to exit.");
Console.ReadKey();