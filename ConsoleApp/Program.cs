// See https://aka.ms/new-console-template for more information

using ConsoleApp;

static int[] NumbersToArray(long number)
{
    return number.ToString().Select(o => int.Parse(o.ToString())).ToArray();
}

Console.WriteLine("Hello, enter the value for the first array:");
if (int.TryParse(Console.ReadLine(), out int intValue1))
{
    Console.WriteLine("You entered {0}.", intValue1);
    Console.WriteLine("Now enter the value for the second array:");
    if (int.TryParse(Console.ReadLine(), out int intValue2))
    {
        Console.WriteLine("You entered {0}.", intValue2);
        var result = NumberUtilities.SumNumbersAsArrays(NumbersToArray(intValue1), NumbersToArray(intValue2));
        Console.WriteLine("The result value is: {0}", string.Join("", result));
    }
    else
    {
        Console.WriteLine("You entered a wrong int value");
    }
}
else
{
    Console.WriteLine("You entered a wrong int value");
}
Console.ReadLine();
