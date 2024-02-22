using DiamondKata;

var cKey = Console.ReadLine();
var input = cKey;
Console.WriteLine();

if (input == null || input.Length > 1)
{
    throw new ArgumentException("Invalid input. Please provide one character");
}

Console.WriteLine(DiamondPrinter.PrintDiamond(input.FirstOrDefault()));
