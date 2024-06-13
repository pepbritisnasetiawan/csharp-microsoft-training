Random coin = new Random(0);

var flip = coin.Next(0, 2);
System.Console.WriteLine((flip == 0) ? "Heads" : "Tails");

System.Console.WriteLine("***********************************************");
System.Console.WriteLine("\t\tExercise");
System.Console.WriteLine("***********************************************");

var permission = "Admin|Manager";
var level = 53;

if (permission.Contains("Admin"))
{
    if (level > 55)
    {
        Console.WriteLine("Welcome, Super Admin user.");
    }
    else
    {
        Console.WriteLine("Welcome, Admin user.");
    }
}
else if (permission.Contains("Manager"))
{
    if (level >= 20)
    {
        Console.WriteLine("Contact an Admin for access.");
    }
    else
    {
        Console.WriteLine("You do not have sufficient privileges.");
    }
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}

System.Console.WriteLine("***********************************************");
System.Console.WriteLine("\t\tExercise");
System.Console.WriteLine("***********************************************");

var outsideAbove = 5;
if (outsideAbove > 0)
{
    var inside = 6;
    outsideAbove += inside;

}
System.Console.WriteLine(outsideAbove);

System.Console.WriteLine("***********************************************");
System.Console.WriteLine("\tExercise Remove Codeblock");
System.Console.WriteLine("***********************************************");

string name = "steve";
if (name == "bob")
    Console.WriteLine("Found Bob");
else if
    (name == "steve") Console.WriteLine("Found Steve");
else
    Console.WriteLine("Found Chuck");

System.Console.WriteLine("***********************************************");
System.Console.WriteLine("\tExercise Remove Codeblock");
System.Console.WriteLine("***********************************************");

int[] numbers = { 4, 8, 15, 16, 23, 42 };
int total = 0;

foreach (int number in numbers)
{
    total += number;
    if (number == 42) Console.WriteLine("Set contains 42");
}

System.Console.WriteLine($"Total: {total}");