using System.Runtime.CompilerServices;

int counter = 0;
Random number = new Random();

Console.WriteLine("Would you like to play? (Y/N)");
if (ShouldPlay())
{
    PlayGame();
}

void PlayGame()
{
    var play = true;

    while (play)
    {
        var target = number.Next(1, 6);
        var roll = number.Next(1, 7);

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(target, roll));
        Console.WriteLine("\nPlay again? (Y/N)");
        counter++;

        play = ShouldPlay();
    }
}

bool ShouldPlay()
{
    bool validChoise = false;

    do
    {
        string? playerChoise = Console.ReadLine();

        if (playerChoise != null)
        {
            if (playerChoise.ToLower() == "y" || playerChoise.ToLower() == "n")
            {
                validChoise = true;

                if (playerChoise.ToLower() == "n")
                {
                    Console.WriteLine("Game finished!");
                    return false;
                }
            }
            else
            {
                Console.WriteLine($"The chosen option is not valid. Please try again\n");
            }
        }
    }
    while (validChoise == false);

    return validChoise;
}

string WinOrLose(int target, int roll)
{
    string result;

    if (roll > target)
    {
        result = "Congratulations! Your roll is greater than the target, so you win!";
    }
    else
    {
        result = "How unfortunate! Your roll is lower than the target, so you lose!";
    }

    return result;
}

