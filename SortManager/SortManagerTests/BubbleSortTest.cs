using SortManagerModel;

namespace SortManagerTests;

internal class BubbleSortTest
{
    [TestCaseSource(typeof(SortTestData), "PosArrays")]
    public void GivenAnArrayofPosIntegers_ReturnsMergeSortedArray(int[] input, int[] expected)
    {
        var sorter = new BubbleSort();
        var actual = sorter.Sort(input);
        Assert.That(actual, Is.EqualTo(expected));
    }
    [TestCaseSource(typeof(SortTestData), "EmptArray")]
    public void GivenAnEmptyArray_returnsAnEmptyArray(int[] input, int[] expected)
    {
        var sorter = new BubbleSort();
        var actual = sorter.Sort(input);
        Assert.That(actual, Is.EqualTo(expected));
    }
    [TestCaseSource(typeof(SortTestData), "NegandPosArrays")]
    public void GivenAnArrayofMixedIntegers_ReturnsMergeSortedArray(int[] input, int[] expected)
    {
        var sorter = new BubbleSort();
        var actual = sorter.Sort(input);
        Assert.That(actual, Is.EqualTo(expected));
    }
}