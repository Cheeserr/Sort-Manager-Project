using SortManagerModel;

namespace SortManagerTests
{
    internal class MergeSortTests
    {
        [TestCaseSource(typeof(SortTestData), "PosArrays")]
        public void GivenAnArrayof1Integers_ReturnsMergeSortedArray(int[] input, int[] expected)
        {
            var sorter = new MergeSort();
            var actual = sorter.Sort(input);
            Assert.That(actual, Is.EqualTo(expected));
        }
        [TestCaseSource(typeof(SortTestData), "EmptArray")]
        public void GivenAnEmptyArray_returnsAnEmptyArray(int[] input, int[] expected)
        {
            var sorter = new MergeSort();
            var actual = sorter.Sort(input);
            Assert.That(actual, Is.EqualTo(expected));
        }
        [TestCaseSource(typeof(SortTestData), "NegandPosArrays")]
        public void GivenAnArrayofMixedIntegers_ReturnsMergeSortedArray(int[] input, int[] expected)
        {
            var sorter = new MergeSort();
            var actual = sorter.Sort(input);
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
