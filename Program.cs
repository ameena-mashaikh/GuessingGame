using System;
using System.Collections.Generic;
using System.Linq;

List<Guess> guess = GetGuess();


Console.WriteLine(@"Select Your Difficulty:
Easy
Medium
Hard");

string diffInp = Console.ReadLine();



Random randNum = new Random();
int secretNum = randNum.Next(0, 101);


Guess easy = new Guess("Easy", 8);
Guess medium = new Guess("Medium", 6);
Guess hard = new Guess("Hard", 4);


foreach (Guess g in guess)
{
    int i = 1;
    //bool eq = g.Difficulty.Equals(diffInp);
    if (g.Difficulty.Equals(diffInp))
    {
        Console.WriteLine("Guess the Secret Number!");
        string userInp = Console.ReadLine();
        int parsedInt = int.Parse(userInp);

        while (i <= (g.NumGuess - 1))
        {
            if (parsedInt == secretNum)
            {
                Console.WriteLine($@"Success! Your guess, {userInp}, is the Secret Number!");
                break;
            }
            else
            {
                if (parsedInt > secretNum)
                {
                    Console.WriteLine($@"Your Previous Guess, {userInp}, is too high. You have {g.NumGuess - i} guesses left. Guess again!");
                }
                else if (parsedInt < secretNum)
                {
                    Console.WriteLine($@"Your Previous Guess, {userInp}, is too low. You have {g.NumGuess - i} guesses left. Guess again!");

                }
                userInp = Console.ReadLine();
                parsedInt = int.Parse(userInp);
                i++;
            }
        }
    }
    // else if (!g.Difficulty.Equals(diffInp))
    // {
    //     // bool eq = !g.Difficulty.Equals(diffInp);
    //     // while (eq)
    //     // {
    //     //     Console.WriteLine(@"Incorrect Difficulty.
    //     //     Please Select Easy, Medium, or Hard");
    //     //     diffInp = Console.ReadLine();
    //     //     if (g.Difficulty.Equals(diffInp))
    //     //     {
    //     //         eq = g.Difficulty.Equals(diffInp);
    //     //     }
    //     //     break;
    //     // }
    //     // bool eq = !g.Difficulty.Equals(diffInp);
    //     // if (eq)
    //     // {
    //     //     Console.Write("Wrong Input. Try Again");
    //     //     diffInp = Console.ReadLine();

    //     // }
    //     // else
    //     // {
    //     //     // eq = g.Difficulty.Equals(diffInp);
    //     // }
    //     Console.WriteLine("Wrong Input. Try Again");
    //     diffInp = Console.ReadLine();
    // }
}

List<Guess> GetGuess()
{
    List<Guess> guess = new List<Guess>
    {
        new Guess("Easy", 8),
        new Guess("Medium", 6),
        new Guess("Hard", 4)
};
    return guess;
}
// int i = 1;
// while (i <= 3)
// {

//     if (parsedInt == secretNum)
//     {
//         Console.WriteLine($@"Success! Your guess, {userInp}, is the Secret Number!");
//         break;
//     }
//     else
//     {
//         // Console.WriteLine($@"Your Previous Guess, {userInp}, is incorrect. You have {4 - i} guesses left. Guess again!");
// if (parsedInt > secretNum)
// {
//     Console.WriteLine($@"Your Previous Guess, {userInp}, is too high. You have {4 - i} guesses left. Guess again!");
// }
// else if (parsedInt < secretNum)
// {
//     Console.WriteLine($@"Your Previous Guess, {userInp}, is too low. You have {4 - i} guesses left. Guess again!");

// }
// userInp = Console.ReadLine();
// parsedInt = int.Parse(userInp);
// i++;
//     }
// }

public class Guess
{
    public string Difficulty { get; set; }
    public int NumGuess { get; set; }

    public Guess(string difficulty, int numGuess)
    {
        Difficulty = difficulty;
        NumGuess = numGuess;
    }
}