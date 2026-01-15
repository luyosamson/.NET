//using System.Numerics;

//int num = 1;
//while (num <= 10)
//{
//    Console.WriteLine($"Number:{num}");
//    num++;
//}

//Console.WriteLine("Enter a number");
//int num2=int.Parse(Console.ReadLine());
//int i = 1;
//int total = 0;
//while (i <= num2){

//    total+= i;
//    i++;

//}
//Console.WriteLine($"The total is {total}");


//count from the number entered downward

//Console.WriteLine("Enter a number to count down from");
//int count=int.Parse(Console.ReadLine());
//while (count >=0)
//{
//    Console.WriteLine($"Number{count}");
//    count--;
//}


//Guess the Number Game

using System;
using System.Diagnostics.Metrics;
using System.Threading.Tasks;

Console.WriteLine("Gues a number");
int g = int.Parse(Console.ReadLine());

int rdm = Random.Shared.Next(1, 5);
//Console.WriteLine($"{rdm}");

while (rdm > g || rdm < g)
{
    Console.WriteLine("You have entered incorrect value,keep guessing");
    rdm++;
}
Console.WriteLine("You have guessed correctly.CONGRATULATIONS!");
//Task:

//Generate a random number between 1 and 50.

//Let the user guess the number.

//Use a while loop to keep asking until they guess correctly.

//Give hints like "Too high" or "Too low".

//Example:

//Guess: 25 → Too low
//Guess: 40 → Too high
//Guess: 32 → Correct!



//5.Password Validation System

//Task:

//Ask the user to enter a password.

//Keep asking using a while loop until they enter the correct password ("admin123").

//Limit attempts to 3 tries.

//If they fail, display: "Access Denied".

//Bonus Challenge:
//Display how many attempts are left after each wrong try.