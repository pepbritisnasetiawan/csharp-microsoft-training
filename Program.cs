/* // Composite formating -> uses a Format() method, uses number as placeholder
string first = "Hello";
string second = "World";
string result = string.Format("{0} {1}!", first, second);
Console.WriteLine(result);
string result2 = string.Format("{0} {0} {0}!", first, second);
Console.WriteLine(result2);

// Striing interpolation
string third = "yohoo";
string fourth = "naaah";
Console.WriteLine($"{third} {fourth}");

// formatting currency -> :C currency format specifier -> digunakan untuk present variable currency
decimal price = 123.33m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})");

// Formatting number -> N numeric format specifier makes numbers more readable
// by default n format only 2 digits after the decimal point
decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N} units"); // Measurement: 123,456.79 units
Console.WriteLine($"Measurement: {measurement:N4} units"); // Measurement: 123,456.7891 units

// Formatting persentage
// uses P as format specifier and rounds to 2 decimal places
decimal tax = .12051m;
Console.WriteLine($"Tax rate: {tax:P2}"); // Tax rate: 36.79%

// combining formatting approaches
decimal salePrice = 59.99m;
string yourDiscount = String.Format("You saved {0:C2} of the regular {1:C} price ", (price - salePrice), price);
Console.WriteLine(yourDiscount);

yourDiscount += $"A discount of {((price - salePrice) / price):P2}!";
Console.WriteLine(yourDiscount);

Console.WriteLine($"Tax rate: {tax:P1}");

int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");
Console.WriteLine($"\tShares: {productShares:N3} Product");
Console.WriteLine($"\t\tSub Total: {subtotal:C}");
Console.WriteLine($"\t\t\tTax: {taxPercentage:P2}");
Console.WriteLine($"\t\tTotal Billed: {total:C}");

Console.WriteLine();
Console.WriteLine("********************************");
Console.WriteLine();

// adding whitespce
string input = "Pad this";
Console.WriteLine(input.PadLeft(12, '-'));
Console.WriteLine(input.PadRight(12, '-'));

// Add the payment id to the output
string paymentId = "769C";
string payeeName = "Mr. Stephen Ortega";
string paymentAmount = "$5,000.00";

var formattedLine = paymentId.PadRight(6);
formattedLine += payeeName.PadRight(24);
formattedLine += paymentAmount.PadLeft(10);

Console.WriteLine("1234567890123456789012345678901234567890");
Console.WriteLine(formattedLine);

 */

string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

// Your logic here
Console.WriteLine($"Dear {customerName},");
Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dracmatically increase your return.\n ");
Console.WriteLine($"Currently, yuou own {currentShares:N} shares at a return of {currentReturn:P}.\n");
Console.WriteLine($"Our ne product, {newProduct} offers a return of {newReturn:P}. Given you current volume, your potential profit would be {newProfit:C}.\n");

Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = "";

// Your logic here
comparisonMessage = comparisonMessage.PadLeft(20);
comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10);
comparisonMessage += String.Format("{0:C}", currentProfit).PadRight(20);

comparisonMessage += "\n";
comparisonMessage += newProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", newReturn).PadRight(10);
comparisonMessage += String.Format("{0:C}", newProfit).PadRight(20);

Console.WriteLine(comparisonMessage);