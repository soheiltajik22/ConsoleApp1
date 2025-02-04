// See https://aka.ms/new-console-template for more information
string your_word = "";
string final_word = "";
bool Gameover = false;
int counter = 0;

Console.WriteLine("Welcome to the Palindrome Game!");
Console.WriteLine("You will be asked to enter a word and the program will check if it is a palindrome.");

string level;
string level;
do
{
    Console.WriteLine("Which level would you like to play? (easy/hard)");
    level = Console.ReadLine();

    if (level != "easy" && level != "hard")
    {
        Console.WriteLine("Please write the correct level."); // Falsche Eingabe wird direkt erkannt
    }

} while (level != "easy" && level != "hard");

Console.WriteLine("You have selected: " + level);


while (!Gameover)
{
    final_word = "";

    Console.WriteLine(level == "easy"
        ? "Please enter a word with at least 3 letters."
        : "Please enter a word with more than 3 letters.");

    your_word = Console.ReadLine();

    if ((level == "easy" && your_word.Length >= 3) ||
        (level == "hard" && your_word.Length > 3))
    {
        if (IsPalindrome(your_word))
        {
            counter++;
            Console.WriteLine("The word you entered is a palindrome.");
        }
        else
        {
            Console.WriteLine("The word you entered is not a palindrome.");
            Console.WriteLine("Your score is: " + counter);

            Console.WriteLine("Do you want to continue? (yes/no)");
            string answer = Console.ReadLine();
            if (answer == "no")
            {
                Gameover = true;
                break;
            }
        }

        Console.WriteLine("Do you want to change the level? (yes/no)");
        string changeLevel = Console.ReadLine();
        if (changeLevel == "yes")
        {
            do
            {
                Console.WriteLine("Which level would you like to play? (easy/hard)");
                level = Console.ReadLine();
            } while (level != "easy" && level != "hard");
        }
    }
    else
    {
        Console.WriteLine("Invalid input. Please try again.");
    }
}


static bool IsPalindrome(string word)
{
    string reversed = "";
    for (int i = word.Length - 1; i >= 0; i--)
    {
        reversed += word[i];
    }
    return word == reversed;
}
