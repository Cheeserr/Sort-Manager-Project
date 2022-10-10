using SortManagerController;

namespace SortManagerTests;

internal class ControllerTests
{

    [Test]
    public void ControllerInitializedIsOfTypeController()
    {
        Controller controller = new Controller();

        Assert.That(controller.GetType(), Is.TypeOf<Controller>());
    }

    [TestCase("1", 1)]
    [TestCase("4", 4)]
    [TestCase("7", 7)]
    public void ControllerParseWithCorrectInputsInBound(string input, int expected)
    {
        int output = Controller.Parse(input);

        Assert.That(output, Is.EqualTo(expected));
    }

    public void ControllerParseWithNull()
    {
        int expected = -1;

        int output = Controller.Parse(null);

        Assert.That(output, Is.EqualTo(expected));
    }

    public void ControllerParseWithSpacesOnly()
    {
        int expected = -1;

        int output = Controller.Parse("  ");

        Assert.That(output, Is.EqualTo(expected));
    }

    public void ControllerParseWithEmptyString()
    {
        int expected = -1;

        int output = Controller.Parse("");

        Assert.That(output, Is.EqualTo(expected));
    }

    public void ControllerParseWithSpacesAndCorrectNumber()
    {
        int expected = 5;

        int output = Controller.Parse("  5  ");

        Assert.That(output, Is.EqualTo(expected));
    }

    public void ControllerParseWithLetterInput()
    {
        int expected = -1;

        int output = Controller.Parse("nothingness");

        Assert.That(output, Is.EqualTo(expected));
    }

    public void ControllerMaxRangeSetInRange()
    {
        Controller controller = new Controller();
        int expected = 75;

        controller.MaxRange = 75;

        Assert.That(controller.MaxRange, Is.EqualTo(expected));
    }

    public void ControllerMaxRangeSetOutOfRange()
    {
        Controller controller = new Controller();
        int expected = 100;

        controller.MaxRange = -100;

        Assert.That(controller.MaxRange, Is.EqualTo(expected));
    }

    public void ControllerMinRangeSetInRange()
    {
        Controller controller = new Controller();
        int expected = 25;

        controller.MinRange = 25;

        Assert.That(controller.MinRange, Is.EqualTo(expected));
    }

    public void ControllerMinRangeSetOutOfRange()
    {
        Controller controller = new Controller();
        int expected = 0;

        controller.MinRange = 100;

        Assert.That(controller.MinRange, Is.EqualTo(expected));
    }

    

}