string[] studentNames = new string[]
{
    "Daniel",
    "Andy",
    "Taj",
    "Min",
    "Adam",
    "Benia",
    "Michael",
    "Devipriya",
    "Syeda",
};
string[] hometowns = new string[]
{
    "Rome",
    "Traverse City",
    "India",
    "Troy",
    "Hamtramak",
    "Austin",
    "Paris",
    "Akron",
    "Birmingham",
};
string[] favoriteFood = new string[]
{
    "Sushi",
    "Thai",
    "Thai",
    "French fries",
    "Pizza",
    "Pasta",
    "Banana pudding",
    "Pizza",
    "Burgers",
};

while (true)
{
    Console.WriteLine($"Welcome! Which student would you like to learn more about? Enter a number 1-{studentNames.Length}"); // start with 1 instead of 0 due to user readability
    string userInput = "";
    int arrayIndex = -1; // set to -1 instead of 0 because 0 is a legitimate index - the array index starts at 0
    bool output = false;

    while (output == false)
    {
        userInput = Console.ReadLine();
        if (int.TryParse(userInput, out arrayIndex) == true)
        {
            if (arrayIndex >= 1 && arrayIndex <= studentNames.Length)
            {
                output = true;
            }
            else
            {
                Console.WriteLine("Please enter a number in the range");
            }

        }
        else
        {
            Console.WriteLine("That is not a valid number, please try again");
        }
    }

    Console.WriteLine($"Student {userInput} is {studentNames[arrayIndex - 1]}"); // have to do -1 due to indexes starting at 0 rather than starting at 1
    Console.WriteLine($"What would you like to know? Enter \"hometown\" or \"favorite food\""); // backward slashes make the next character a literal rather than actual code - allows for quotes

    output = false;
    string userCategory = "";
    while (output == false)
    {
        userCategory = Console.ReadLine().ToLower().Trim();
        {
            switch (userCategory)
            {
                case "hometown":
                case "home":
                case "town":
                    Console.WriteLine($"{studentNames[arrayIndex - 1]} is from {hometowns[arrayIndex - 1]}");
                    output = true;
                    break;
                case "favorite food":
                case "favorite":
                case "food":
                    Console.WriteLine($"{studentNames[arrayIndex - 1]}'s favorite food is {favoriteFood[arrayIndex - 1]}");
                    output = true;
                    break;
                default:
                    Console.WriteLine("That category does not exist. Please try again. Enter \"hometown\" or \"favorite food\"");
                    output = false;
                    break;
            }
        }
    }
    Console.WriteLine("Would you like to see a list of students? Enter \"y\" or \"n\"");
    string userAnswer = Console.ReadLine().ToLower().Trim();
    {
        if (userAnswer == "y")
        {
            int studentCounter = 1;
            foreach (string student in studentNames) // can also use for loop (for (int i = 0; i < studentNames.Length; i++) --> Console.WriteLine($"{i + 1}: {studentNames[i]}");
            {
                Console.WriteLine($"{studentCounter}: {student}");
                studentCounter++;
            }
        }
    }
    Console.WriteLine("Enter the student name you'd like to search for");
    string searchName = Console.ReadLine();
    int indexOfSearch = -1;
    {
        for (int i = 0; i < studentNames.Length; i++)
        {
            if (studentNames[i].ToLower() == searchName.ToLower())
            {
                indexOfSearch = i;
                break;
            }
        }
        if (indexOfSearch > -1)
        {
            Console.WriteLine($"{searchName} is student number {indexOfSearch + 1}"); // +1 due to needing to display the correct number to the user
        }
    }
    Console.WriteLine("Would you like to learn about another student? Enter \"y\" or \"n\"");
    string userAgree = Console.ReadLine();
    if (userAgree != "y")
    {
        break;
    }
}
Console.WriteLine("Press any key to exit");
Console.ReadKey();
Console.WriteLine();
Console.WriteLine("Goodbye!");