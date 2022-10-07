using SortManagerModel;

namespace SortManagerTests;

internal class BubbleSortTest
{
    [TestCaseSource(typeof(SortTestData), nameof(SortTestData.PosArrays))]
    public void GivenAnArrayofPosIntegers_ReturnsMergeSortedArray(int[] input, int[] expected)
    {
        var sorter = new BubbleSort();
        var actual = sorter.Sort(input);
        Assert.That(actual, Is.EqualTo(expected));
    }
    [TestCaseSource(typeof(SortTestData), nameof(SortTestData.EmptArray))]
    public void GivenAnEmptyArray_returnsAnEmptyArray(int[] input, int[] expected)
    {
        var sorter = new BubbleSort();
        var actual = sorter.Sort(input);
        Assert.That(actual, Is.EqualTo(expected));
    }
    [TestCaseSource(typeof(SortTestData), nameof(SortTestData.NegandPosArrays))]
    public void GivenAnArrayofMixedIntegers_ReturnsMergeSortedArray(int[] input, int[] expected)
    {
        var sorter = new BubbleSort();
        var actual = sorter.Sort(input);
        Assert.That(actual, Is.EqualTo(expected));
    }
    [Test]
    public void TestNullCaseThrowsexception()
    {
        int[] input = null!;
        var sorter = new BubbleSort();
        Assert.That(() => sorter.Sort(input), Throws.TypeOf<ArgumentNullException>());
    }
}