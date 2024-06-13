/*
=> For statement
    iterates through a code block a spesific number of times.
    Much more control over the process of iteration by exposing the conditions for iteration
=> Foreach statement
    Iterates through a block of code once for each item in a squance of data like an array or collections
=> While statement
    Iterates through a block of code until a condition is met.
*/

// basic
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Iterasi ke-{i}");
}

System.Console.WriteLine("===================================================");
System.Console.WriteLine("\t\tLoop Through each element");
System.Console.WriteLine("===================================================");

// mulai dari belakang
string[] names = { "Alex", "Eddie", "David", "Michaell" };
for (int i = names.Length - 1; i >= 0; i--)
{
    System.Console.WriteLine(names[i]);
}

System.Console.WriteLine("===================================================");
System.Console.WriteLine("\t\tLoop Through each element then replace value");
System.Console.WriteLine("===================================================");

// replace value
for (int i = 0; i < names.Length; i++)
{
    if (names[i] == "David")
    {
        names[i] = "Febrian";
    }
}

foreach (string name in names)
{
    System.Console.WriteLine(name);
}

System.Console.WriteLine("===================================================");
System.Console.WriteLine("\t\tFizzBuzz");
System.Console.WriteLine("===================================================");

for (int i = 1; i <= 100; i++)
{
    if ((i % 3 == 0) && (i % 5 == 0))
    {
        System.Console.WriteLine("FizzBuzz");
    }
    else if (i % 3 == 0)
    {
        System.Console.WriteLine("Fizz");
    }
    else if (i % 5 == 0)
    {
        System.Console.WriteLine("Buzz");
    }
    else
    {
        System.Console.WriteLine(i);
    }
}