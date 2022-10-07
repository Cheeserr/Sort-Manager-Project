using SortManagerModel;
namespace SortManagerTests;
internal class PancakeSortTests
{
    [TestCaseSource(typeof(SortTestData), nameof(SortTestData.PosArrays))]
    public void GivenAnArrayofPosIntegers_ReturnsMergeSortedArray(int[] input, int[] expected)
    {
        var sorter = new PancakeSort();
        var actual = sorter.Sort(input);
        Assert.That(actual, Is.EqualTo(expected));
    }
    [TestCaseSource(typeof(SortTestData), nameof(SortTestData.EmptArray))]
    public void GivenAnEmptyArray_returnsAnEmptyArray(int[] input, int[] expected)
    {
        var sorter = new PancakeSort();
        var actual = sorter.Sort(input);
        Assert.That(actual, Is.EqualTo(expected));
    }
    [TestCaseSource(typeof(SortTestData), nameof(SortTestData.NegandPosArrays))]
    public void GivenAnArrayofMixedIntegers_ReturnsMergeSortedArray(int[] input, int[] expected)
    {
        var sorter = new PancakeSort();
        var actual = sorter.Sort(input);
        Assert.That(actual, Is.EqualTo(expected));
    }
}

