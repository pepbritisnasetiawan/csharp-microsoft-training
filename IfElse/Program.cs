Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

System.Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        System.Console.WriteLine("You rolled triples! +6 to total");
        total += 6;
    }
    else
    {
        System.Console.WriteLine("You rolled doubles! +2 bonuss to toal!");
        total += 2;
    }
}
if (total >= 16)
{
    System.Console.WriteLine("You a new car!");
}
else if (total >= 10)
{
    System.Console.WriteLine("You win a new laptop!");
}
else if ((total == 7))
{
    System.Console.WriteLine("You win a trip for two!");
}
else
{
    System.Console.WriteLine("You win a kitten!");
}

var message = "The quick brown fox jumps over the lazy dog.";
var result = message.Contains("dog");
System.Console.WriteLine(result);

if (message.Contains("fox"))
{
    System.Console.WriteLine("What does the fox say?");
}

System.Console.WriteLine("-------------------------------------------------------------------------------------");

Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;
if (daysUntilExpiration == 0)
{
    System.Console.WriteLine("Your subscription has expired.");
}
if (daysUntilExpiration == 1)
{
    System.Console.WriteLine("Your subscription expires within a day!");
    discountPercentage += 20;
}
else if (daysUntilExpiration <= 5)
{
    System.Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
    discountPercentage += 10;
}
else if (daysUntilExpiration <= 10)
{
    System.Console.WriteLine("Your subscription will expires soon. Renew now!");
}
if (discountPercentage > 0)
{
    System.Console.WriteLine($"Renew now and save {discountPercentage}%.");
}