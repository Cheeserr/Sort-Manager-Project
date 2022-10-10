using System.Text;

namespace SortManagerController;

public class Controller : SortFactory
{
    public enum Sorts
    {
        BubbleSort,
        HeapSort,
        InsertionSort,
        MergeSort,
        NetSort,
        PancakeSort,
        SelectionSort
    }

    private Profiler profiler = new Profiler();
    public string GetProfilerResult() => profiler.ToString();

    int[] _array = { };
    private int _minRange = 0;
    private int _maxRange = 100;
    public int MinRange
    {
        get => _minRange;
        set
        {
            if (value < _maxRange)
            {
                _minRange = value;
            }
        }
    }
    public int MaxRange
    {
        get => _maxRange;
        set
        {
            if (value > _minRange)
            {
                _maxRange = value;
            }
        }
    }

    public Controller() { }

    public static int Parse(string? choice)
    {
        if (choice is null || choice.Trim() is "") return -1;

        if (Int32.TryParse(choice, out int num))
        {
            if (num < 1 || num > 7)
                return -1;
            return num;
        }
        return -1;
    }


    public void ArrayGenerator(int arraySize)
    {
        Random random = new Random();
        int[] output = new int[arraySize];

        for (int i = 0; i < arraySize; i++)
        {
            output[i] = random.Next(MinRange, MaxRange);
        }

        _array = output;
    }

    public void SortArray(int value)
    {
        _array = profiler.ProfileFunctionInline(() => ChooseSort(value).Sort(_array));
    }

    public string ArrayToString()
    {
        StringBuilder sb = new StringBuilder("");

        foreach (var element in _array)
        {
            sb.Append(element.ToString() + " ");
        }

        return sb.ToString().Trim();
    }


}