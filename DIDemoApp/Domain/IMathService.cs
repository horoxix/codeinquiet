namespace DIDemoApp;

public interface IMathService
{
    int Sum(int x, int y);
    int Difference(int x, int y);
    int HighestValue(List<int> values);
    int LowestValue(List<int> values);
}
