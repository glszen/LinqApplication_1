List<int> random = new List<int> { 5, 6, -8, 9, 10, -13, 18, -20, 1};

var randomNumbersEven = random.Where(x => x % 2 == 0); //For even numbers.

Console.WriteLine("Even Numbers: ");

foreach (var result in randomNumbersEven)
{
    Console.WriteLine(result);
}

Console.WriteLine("\n-----------------\n");

var randomNumbersOddNumbers = random.Where(x => x % 2 != 0); //For odd numbers.

Console.WriteLine("Odd Numbers: ");

foreach (var result2 in randomNumbersOddNumbers)
{
    Console.WriteLine(result2);
}

Console.WriteLine("\n-----------------\n");

var randomNumbersNegative = random.Where(x => x < 0); //For negative numbers.

Console.WriteLine("Negative Numbers: ");

foreach (var result3 in randomNumbersNegative)
{
    Console.WriteLine(result3);
}

Console.WriteLine("\n-----------------\n");

var randomNumbersPositive = random.Where(x => x > 0);

Console.WriteLine("Positive Numbers: "); //For positive numbers.

foreach (var result4 in randomNumbersPositive)
{
    Console.WriteLine(result4);
}

Console.WriteLine("\n-----------------\n");

var limtedNumbers = random.Where(x => x > 15 && x < 22); //To get numbers in a certain range.

Console.WriteLine("Limited Numbers: ");

foreach (var result5 in limtedNumbers)
{
    Console.WriteLine(result5);
}

Console.WriteLine("\n-----------------\n");

var squareNumbers = random.Select(x => x*x); //Select method was used because we were going to square it.

Console.WriteLine("Squared Numbers: ");

foreach (var result6 in squareNumbers)
{
    Console.WriteLine(result6);
}