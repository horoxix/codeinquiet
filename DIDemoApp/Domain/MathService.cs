using System.Text;

using Microsoft.Extensions.Logging;

namespace DIDemoApp.Domain;

public class MathService : IMathService
{
    private readonly ILogger<MathService> _logger;

    public MathService(ILogger<MathService> logger)
    {
        _logger = logger;
    }

    public int Sum(int x, int y)
    {
        var sum = x + y;
        _logger.LogInformation("Calculating Sum of {x} + {y}. Result = {z}",
            x, y, sum);

        return sum;
    }

    public int Difference(int x, int y)
    {
        var difference = x - y;
        _logger.LogInformation("Calculating Difference of {x} - {y}. Result = {z}",
            x, y, difference);

        return difference;
    }

    public int HighestValue(List<int> values)
    {
        var highestValue = values.Max(x => x);
        _logger.LogInformation("Calculating HighestValue in {listOfValues}. Result = {highestValue}",
            ListOfValues(values),
            highestValue);

        return highestValue;
    }

    public int LowestValue(List<int> values)
    {
        var lowestValue = values.Min(x => x);
        _logger.LogInformation("Calculating LowestValue in {listOfValues}. Result = {lowestValue}",
            ListOfValues(values),
            lowestValue);

        return lowestValue;
    }

    private string ListOfValues(List<int> values)
    {
        StringBuilder stringBuilder = new();

        foreach (var value in values)
        {
            stringBuilder.Append($" {value.ToString()}, ");
        }

        return stringBuilder.ToString();
    }
}
