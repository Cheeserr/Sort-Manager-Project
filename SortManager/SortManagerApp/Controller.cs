using System.Drawing;
using System.Text;
using SortManagerModel;

namespace SortManagerController;

public class Controller : SortFactory
{
    public Profiler profiler = new Profiler();
    int[] array = { };

    bool descending = false;

    private int _minRange;
    private int _maxRange;
    public int minRange
    {
        get  => _minRange;
        set
        {
            if (value < _maxRange)
            {
                _minRange = value;
            }
        }
    }
    public int maxRange
    {
        get => maxRange;
        set
        {
            if (value > _minRange)
            {
                _maxRange = value;
            }
        }
    }
    
    public Controller()
    {
        minRange = 0;
        maxRange = 100;
    }

    public int Parse(string? choice, int minOption, int maxOption)
    {
        if (choice is null) return -1;

        if(Int32.TryParse(choice, out int num))
        {
            if (num < minOption || num > maxOption)
                return -1;

        }
        return num;
    }

    public void GenerateArray(int arraySize)
    {
        array = ArrayGenerator(arraySize);
    }

    int[] ArrayGenerator(int arraySize)
    {
        Random random = new Random();
        int[] output = new int[arraySize];

        for (int i = 0; i < arraySize; i++)
        {
            output[i] = random.Next(minRange, maxRange);
        }

        return output;
    }

    public void SortArray(int value)
    {
        array = profiler.ProfileFunctionInline(() => ChooseSort(value).Sort(array));
    }

    public string ArrayToString()
    {
        StringBuilder sb = new StringBuilder("");

        foreach(var element in array)
        {
            sb.Append(element.ToString() + " ");
        }

        return sb.ToString().Trim();
    }
}