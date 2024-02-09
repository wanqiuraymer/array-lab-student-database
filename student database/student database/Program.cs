// See https://aka.ms/new-console-template for more information

using System.Globalization;
using System.Reflection.Metadata.Ecma335;

Console.WriteLine("Hello, World!");
bool tryAgain = true;
string[] studentName = new string[] { "Liam", "Noah", "Emma", "Ava", "Lucas", "Henry", "James", "Amelia", "Charlotte" };
string[] hometown = new string[] { "Troy", "Rochester", "Pontiac", "Chicago", "New York", "Oxford", "Miami", "Charlotte", "New Orleans" };
string[] food = new string[] { "Pasta", "Sandwich", "Dumplings", "Steak", "Shrimp", "Cheese Cake", "Taco", "Pho", "Noodes" };
bool catagoryExist = true;
string students = String.Join(", ", studentName);
Console.WriteLine($"Students on the list are: {students}");
/*while (tryAgain)   // search students by number
{
    Console.WriteLine($"Welcome! Which student would you like to learn more about? Enter a number 1-{studentName.Length}:");
    int userNum = int.Parse(Console.ReadLine());
    if (userNum < 1 || userNum > studentName.Length)
    {
        Console.WriteLine("The number is out of range. Please try again!");
        continue;
    }
    else
    {
        Console.Write($"Student {userNum} is {studentName[userNum - 1]}. ");
    }
    do
    {
        Console.WriteLine("What would you like to know? Enter 'hometown' or 'favorite food': ");
        string userChoice = Console.ReadLine().ToLower();           
        if (userChoice.Contains("home"))
        { 
            Console.WriteLine($"{studentName[userNum - 1]} is from {hometown[userNum - 1]}.");
            catagoryExist = true;
        }
        else if (userChoice.Contains("food"))
        {
            Console.WriteLine($"{studentName[userNum - 1]}'s favorite food is {food[userNum - 1]}.");
            catagoryExist = true;
        }
        else
        {
            Console.WriteLine("That category doesn't exist. Please try again!");
            catagoryExist = false;
        }
    } while (catagoryExist == false);
    Console.WriteLine("Would you like to learn about another student? Enter \"y\" or \"n\": ");
    
    if (Console.ReadLine().ToLower() != "y") { Console.WriteLine("Thanks!"); tryAgain = false; }
}
*/
int studentIndex = 0;
while (tryAgain)   // search students by name
{
    Console.WriteLine($"Welcome! Which student would you like to learn more about? Enter the student's name:");
    TextInfo textinfo = new CultureInfo("en-US", false).TextInfo;
    textinfo = CultureInfo.CurrentCulture.TextInfo;
    string userInput = textinfo.ToTitleCase(Console.ReadLine().ToLower().Trim());

    if (studentName.Contains(userInput))
    {
        studentIndex = Array.IndexOf(studentName, userInput);
        do
        {
            Console.WriteLine($"What would you like to know about {userInput}? Enter 'hometown' or 'favorite food': ");
            string userChoice = Console.ReadLine().ToLower();
            if (userChoice.Contains("home"))
            {
                Console.WriteLine($"{userInput} is from {hometown[studentIndex]}.");
                catagoryExist = true;
            }
            else if (userChoice.Contains("food"))
            {
                Console.WriteLine($"{userInput}'s favorite food is {food[studentIndex]}.");
                catagoryExist = true;
            }
            else
            {
                Console.WriteLine("That category doesn't exist. Please try again!");
                catagoryExist = false;
            }
        } while (catagoryExist == false);
        Console.WriteLine("Would you like to learn about another student? Enter \"y\" or \"n\": ");

        if (Console.ReadLine().ToLower() != "y") { Console.WriteLine("Thanks!"); tryAgain = false; }

    }
    else { Console.WriteLine($"{userInput} is not on the list. Please try again!"); }
}
Console.Read();


