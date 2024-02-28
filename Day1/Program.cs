namespace Day1;

class Program
{
    private const string LinesSeparator = "\r\n";

    private readonly Dictionary<string, int> _spelledDigits = new()
    { 
        { "one", 1 },
        { "two", 2 },
        { "three", 3 },
        { "four", 4 },
        { "five", 5 },
        { "six", 6 },
        { "seven", 7 },
        { "eight", 8},
        { "nine", 9 }
    };

    static void Main(string[] args)
    {
        var inputFileName = args.Length == 0 ? "input.txt" : args[0];
        string[] data;
        
        using (var streamReader = new StreamReader(inputFileName))
            data = streamReader
                .ReadToEnd()
                .Split(LinesSeparator, StringSplitOptions.RemoveEmptyEntries);
        
        var total = 0;
        var total2 = 0;

        foreach (var line in data)
        {
            var tokensToAdd = string.Empty;
            var tokenToAdd2 = "0";
            var length = line.Length;
            char current;
            int i;

            for (i = 0; i < length; ++i)
            {
                current = line[i];
                if (char.IsDigit(current))
                {
                    tokensToAdd += current;
                    break;
                }
            }

            for (i = length - 1; i >= 0; --i)
            {
                current = line[i];
                if (char.IsDigit(current))
                {
                    tokensToAdd += current;
                    break;
                }
            }
            
            total += Convert.ToInt32(tokensToAdd);
            total2 += Convert.ToInt32(tokenToAdd2);
        }

        Console.WriteLine($"Part 1. Sum = {total}");
        Console.WriteLine($"Part 2. Now sum = {total2}");
    }
}
