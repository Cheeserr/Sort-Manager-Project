using SortManagerController;

namespace SortManagerTests;

public class Tests
{

    [TestCase(0)]
    [TestCase(1)]
    [TestCase(10)]
    public void GivenArrayLength_teurnsArrayOfCorrectLerngth(int length)
    {
        //Random rand = new Random((int)1);
        int[] result = Controller.ArrayGenerator(length);
        Assert.That(result.Length,Is.EqualTo(length));
    }
}