string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
string result = new string(valueArray);
string result2 = String.Join(",", valueArray); 
Console.WriteLine(result);
Console.WriteLine(result2);

string[] items = result2.Split(',');
foreach (string item in items)
{
    Console.WriteLine(item);
}

/*
Use method like ToCharArray() adn Split() to create an array
Use method like join(), or create a new string passing in an array of char
to turn the array back into single string
*/

Console.WriteLine("");

string pangram = "The quick brown fox jumps over the lazy dog";

// Step 1
string[] message = pangram.Split(' ');

//Step 2
string[] newMessage = new string[message.Length];

// Step 3
for (int i = 0; i < message.Length; i++)
{
    char[] letters = message[i].ToCharArray();
    Array.Reverse(letters);
    newMessage[i] = new string(letters);
}

//Step 4
string resultP = String.Join(" ", newMessage);
Console.WriteLine(resultP);

// challenge
Console.WriteLine("");

string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] newOrderStream = orderStream.Split(',');
Array.Sort(newOrderStream);

foreach (string l in newOrderStream)
{
    if (l.Length == 4)
    {
        Console.WriteLine(l);
    }
    else
    {
        Console.WriteLine($"{l} - Error");
    }
}