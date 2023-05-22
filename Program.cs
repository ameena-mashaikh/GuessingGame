using System;
using System.Collections.Generic;
using System.Linq;

Console.WriteLine("Guess the Secret Number");
string userInp = Console.ReadLine();
int parsedInt = int.Parse(userInp);
int secretNum = 42;
if (parsedInt == secretNum)
{
    Console.WriteLine("Success! You guessed the Secret Number");
}
else
{
    Console.WriteLine("Sadly you guessed the wrong number");
}
