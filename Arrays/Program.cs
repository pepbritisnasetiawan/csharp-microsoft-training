string[] fraudulentOrderIDs = new string[3]; // [3] is the length of the array

// assign value
fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";

System.Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
System.Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
System.Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

// Array can be reassign
fraudulentOrderIDs[0] =  "R345";
System.Console.WriteLine($"Reassign: {fraudulentOrderIDs[0]}");

// Initialize an array during declaration
string[] countries = {"Indonesia", "Serbia", "Rusia", "Japan"};

System.Console.WriteLine($"First country: {countries[0]}");
System.Console.WriteLine($"Second country: {countries[1]}");
System.Console.WriteLine($"Third country: {countries[2]}");
System.Console.WriteLine($"Third country: {countries[3]}");

// reassign
countries[3] = "Chile";
System.Console.WriteLine($"Reassign: {countries[3]}");

// check the length of the array
System.Console.WriteLine($"The length of the array countries is : {countries.Length}");

// looping through an array using foreach
foreach (string country in countries)
{
    System.Console.WriteLine(country);
}

System.Console.WriteLine("==================================================");
int[] inventory = {200, 400, 700, 800, 900};
int sum = 0;
int bin = 0;
foreach(int items in inventory)
{
    sum += items;
    bin++;
    System.Console.WriteLine($"Bin {bin} = {items} (Running total : {sum})");
}
System.Console.WriteLine($"We have {sum} items in inventory");

System.Console.WriteLine("=====================================");
System.Console.WriteLine("\t\tChallenge");
System.Console.WriteLine("=====================================");

string[] fraudOrderIDs = {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};
foreach (string fraud in fraudOrderIDs)
{
    if (fraud.StartsWith("B"))
    {
        System.Console.WriteLine(fraud);
    }
}

System.Console.WriteLine("=====================================");
System.Console.WriteLine("\t\tExercise");
System.Console.WriteLine("=====================================");

Random random = new Random();
string[] orderIDS = new string[26];
for (int i = 0; i < orderIDS.Length; i++)
{
    // get random value that equates to ASCII letters A through O
    int prefixValue = random.Next(65, 80);
    // convert value to char and then to string
    string prefix = Convert.ToChar(prefixValue).ToString();
    // create a random number, pad with zeroes
    string suffix = random.Next(1, 1000).ToString("000");
    // combine the prefix and suffix together, then assign to current orderid
    orderIDS[i] = prefix + suffix;
}

foreach (string orderID in orderIDS)
{
    System.Console.WriteLine(orderID);
}

System.Console.WriteLine("=====================================");
System.Console.WriteLine("\t\tChallenge");
System.Console.WriteLine("=====================================");

/*
   This code reverses a message, counts the number of times 
   a particular character appears, then prints the results
   to the console window.
 */

string originalMessage = "The quick brown fox jumps over the lazy dog.";

char[] message = originalMessage.ToCharArray();
Array.Reverse(message);

int letterCount = 0;

foreach (char letter in message)
{
    if (letter == 'o')
    {
        letterCount++;
    }
}

string newMessage = new String(message);

Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {letterCount} times.");