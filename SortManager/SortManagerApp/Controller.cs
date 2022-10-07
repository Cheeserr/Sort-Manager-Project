using System.Drawing;
using System.Text;
using SortManagerModel;

namespace SortManagerController;

public class Controller
{
    public Profiler profiler = new Profiler();
    ISortable? sortMethod = null;
    int[] array;

    private int _minRange;
    private int _maxRange;
    public int minRange
    {
        get
        {
            return _minRange;
        }
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
        get
        {
            return _maxRange;
        }
        set
        {
            if (value > _minRange)
            {
                _maxRange = value;
            }
        }
    }
    public Controller(int arraySize)
    {
        minRange = 0;
        maxRange = 100;

        array = GenerateArray(arraySize);
    }

    public void ChooseSort(int value)
    {
        switch (value)
        {
            case 0:
                sortMethod = new BubbleSort();
                break;
            case 1:
                sortMethod = new MergeSort();
                break;
            case 2:
                sortMethod = new SelectionSort();
                break;
            case 3: sortMethod = new NetSort();
                break;
            case 4: sortMethod = new InsertionSort();
                break;
            default:
                break;
        }
    }

    public int[] SortArray()
    {
        return profiler.ProfileFunctionInline(() => sortMethod.Sort(array));
    }


    int[] GenerateArray(int arraySize)
    {
        Random random = new Random();
        int[] output = new int[arraySize];

        for (int i = 0; i < arraySize; i++)
        {
            output[i] = random.Next(minRange, maxRange);
        }

        return output;
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