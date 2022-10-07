using System.Drawing;
using System.Text;
using SortManagerModel;

namespace SortManagerController;

public class Controller : SortFactory
{
    public Profiler profiler = new Profiler();
    int[] array;

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

    public override ISortable ChooseSort(int choosenSort)
    {
        switch (choosenSort)
        {
            case 0: return new BubbleSort();
            case 1: return new MergeSort();
            case 2: return new SelectionSort();
            case 3: return new NetSort();
            case 4: return new InsertionSort();
            default: return new BubbleSort();
        }
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

    public int[] SortArray(int value)
    {
        return profiler.ProfileFunctionInline(() => ChooseSort(value).Sort(array));
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