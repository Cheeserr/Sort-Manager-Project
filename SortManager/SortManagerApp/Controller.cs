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

    int[] _unsortedArray = { };
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

        _unsortedArray = output;
    }

    public void SortArray(int value)
    {
        _array = profiler.ProfileFunctionInline(() => ChooseSort(value).Sort(_unsortedArray));
    }

    public string TestAll(int value)
    {

        Console.WriteLine("\n");
        StringBuilder sb = new StringBuilder("");
        for(int i = 1; i <= 7; i++)
        {
            if(i != value)
            {
                profiler.ProfileFunctionInline(() => ChooseSort(i).Sort(_unsortedArray));
                sb.Append(Enum.GetName(typeof(Sorts), i - 1) + " " +  GetProfilerResult() + "\n");
            }
        }
        return sb.ToString();
    }

    public string ShowSorted()
    {
        return ArrayToString(_array);
    }

    public string ShowUnsorted()
    {
        return ArrayToString(_unsortedArray);
    }

    public string ArrayToString(int[] array)
    {
        StringBuilder sb = new StringBuilder("");

        foreach (var element in array)
        {
            sb.Append(element.ToString() + " ");
        }

        return sb.ToString().Trim();
    }


}