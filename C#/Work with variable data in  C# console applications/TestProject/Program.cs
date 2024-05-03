string[] values = {"12.3", "45", "ABC", "11", "DEF"};
decimal numericValue = 0;
decimal accumulator = 0;
string alphabeticValue = "";

foreach (string value in values)
{
    if(decimal.TryParse(value, out numericValue))
    {
        accumulator += numericValue;
    }
    else
    {
        alphabeticValue += value;
    }
}

Console.WriteLine($"\nMessage: {alphabeticValue}");
Console.WriteLine($"Total: {accumulator}\n");


