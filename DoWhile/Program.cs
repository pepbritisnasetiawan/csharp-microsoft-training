﻿using System.Runtime.InteropServices;

Random random = new Random();
int current = random.Next(1, 11);

do
{
    current = random.Next(1, 11);
    if (current >= 8) continue;

    System.Console.WriteLine(current);

} while (current != 7);

// while (current >= 3)
// {
//     System.Console.WriteLine(current);
//     current = random.Next(1, 11);
// }
// System.Console.WriteLine($"Last number: {current}");

System.Console.WriteLine("==================================================");
System.Console.WriteLine("\t\tMonster vs Hero");
System.Console.WriteLine("==================================================");

/*
Code challenge - write code to implement the game rules
Here are the rules for the battle game that you need to implement in your code project:

You must use either the do-while statement or the while statement as an outer game loop.
The hero and the monster start with 10 health points.
All attacks are a value between 1 and 10.
The hero attacks first.
Print the amount of health the monster lost and their remaining health.
If the monster's health is greater than 0, it can attack the hero.
Print the amount of health the hero lost and their remaining health.
Continue this sequence of attacking until either the monster's health or hero's health is zero or less.
Print the winner.
*/

int hero = 10;
int monster = 10;

Random dice = new Random();

do
{
    int roll = dice.Next(1, 11);
    monster -= roll;
    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

    if (monster <= 0) continue;

    roll = dice.Next(1, 11);
    hero -= roll;
    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

} while (hero > 0 && monster > 0);

Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");

System.Console.WriteLine("==================================================");
System.Console.WriteLine("\t\tManage user input");
System.Console.WriteLine("==================================================");

string? readResult;
bool validEntry = false;
System.Console.WriteLine("Enter a string containing at least three characters: ");
do{
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        validEntry = true;
    }
    else
    {
        System.Console.WriteLine("Your input is invalid, please try again.");
    }
} while (validEntry == false);

