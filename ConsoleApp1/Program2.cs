using System;

int your_Guess;

Console.WriteLine("Please guess a number in your mind.");
int RandomNumber = new Random().Next(0, 100);
Console.WriteLine("Is your guessed number " + RandomNumber + "?");
Console.WriteLine("If your guess is bigger, press 'B'. If it is smaller, press 'S'. To stop, press 'R'.");

string Input = Console.ReadLine();
Random random = new Random();
int bigger = 0;
int smaller = 100;


while (Input.ToLower() != "r")
{
    if (Input.ToLower() == "b")
    {
        bigger = RandomNumber + 1;
        RandomNumber = random.Next(bigger, smaller);
        Console.WriteLine("Is it " + RandomNumber + "?");

    }
    else if (Input.ToLower() == "s")
    {
        smaller = RandomNumber;
        RandomNumber = random.Next(bigger, smaller);
        Console.WriteLine("Is it " + RandomNumber + "?");
    }

    

    Input = Console.ReadLine();
}

Console.WriteLine("End of Code.");
