// Random dice = new Random();
// // int roll = dice.Next(1, 7);
// var roll = dice.Next(2, 6);
// Console.WriteLine(roll);

Random dice = new Random();

int roll1 = dice.Next();
int roll2 = dice.Next(101);
int roll3 = dice.Next(50, 101);

System.Console.WriteLine($"First roll: {roll1}");
System.Console.WriteLine($"Second roll: {roll2}");
System.Console.WriteLine($"Third roll: {roll3}");