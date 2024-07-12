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