namespace SampleService.Tests;

public class Tests
{
    private DemoService _demoService;

    [SetUp]
    public void Setup()
    {
        _demoService = new DemoService();
    }

    [Test]
    public void Test1()
    {
        var result = _demoService.IsMoreThan2(1);
        Assert.IsFalse(result, "1 is less than 2");
        Assert.Pass();
    }
}