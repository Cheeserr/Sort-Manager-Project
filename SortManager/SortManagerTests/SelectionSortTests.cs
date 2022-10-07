using SortManagerModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortManagerTests;

internal class SelectionSortTests
{
    [TestCaseSource(typeof(SortTestData), nameof(SortTestData.PosArrays))]
    public void GivenAnArrayofPosIntegers_ReturnsMergeSortedArray(int[] input, int[] expected)
    {
        var sorter = new SelectionSort();
        var actual = sorter.Sort(input);
        Assert.That(actual, Is.EqualTo(expected));
    }
    [TestCaseSource(typeof(SortTestData), nameof(SortTestData.EmptArray))]
    public void GivenAnEmptyArray_returnsAnEmptyArray(int[] input, int[] expected)
    {
        var sorter = new SelectionSort();
        var actual = sorter.Sort(input);
        Assert.That(actual, Is.EqualTo(expected));
    }
    [TestCaseSource(typeof(SortTestData), nameof(SortTestData.NegandPosArrays))]
    public void GivenAnArrayofMixedIntegers_ReturnsMergeSortedArray(int[] input, int[] expected)
    {
        var sorter = new SelectionSort();
        var actual = sorter.Sort(input);
        Assert.That(actual, Is.EqualTo(expected));
    }
}
