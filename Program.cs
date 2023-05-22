using System;
using System.Collections.Generic;
using System.Linq;

Console.WriteLine("Guess the Secret Number");
string userInp = Console.ReadLine();
int parsedInt = int.Parse(userInp);
int secretNum = 42;

int i = 1;
while (i <= 3)
{

    if (parsedInt == secretNum)
    {
        Console.WriteLine($@"Success! Your guess, {userInp}, is the Secret Number!");
        break;
    }
    else
    {
        Console.WriteLine($@"Your Previous Guess, {userInp}, is incorrect. Guess again!");
        userInp = Console.ReadLine();
        parsedInt = int.Parse(userInp);
        i++;
    }
}