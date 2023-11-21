using DIDemoApp.Models;

namespace DIDemoApp.App;

public class BusinessLogic
{
    private readonly IMathService _mathService;

    public BusinessLogic(IMathService mathService)
    {
        _mathService = mathService;
    }

    public int AddHighestValueToLowestValue(IncomingRequest incomingRequest)
    {
        var highestValue = _mathService.HighestValue(incomingRequest.Values);
        var lowestValue = _mathService.LowestValue(incomingRequest.Values);

        return _mathService.Sum(highestValue, lowestValue);
    }

    public int SubtractLowestValueFromHighestValue(IncomingRequest incomingRequest)
    {
        var highestValue = _mathService.HighestValue(incomingRequest.Values);
        var lowestValue = _mathService.LowestValue(incomingRequest.Values);

        return _mathService.Difference(highestValue, lowestValue);
    }
}