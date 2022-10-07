using System.Diagnostics;

namespace SortManagerController;

public class Profiler
{
    private Stopwatch _stopwatch;
    public double Milliseconds
    {
        get
        {
            return _stopwatch.Elapsed.TotalMilliseconds;
        }
    }

    public Profiler()
    {
        _stopwatch = new Stopwatch();
    }

    public T ProfileFunctionInline<T>(Func<T> func)
    {
        _stopwatch.Reset();
        _stopwatch.Start();
        var result = func.Invoke();
        _stopwatch.Stop();
        return result;
    }
}
