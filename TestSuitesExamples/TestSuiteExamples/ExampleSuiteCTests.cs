namespace TestSuitesExamples;

[Collection("SuiteA")]
public class ExampleSuiteCTests
{
    [Fact(DisplayName = "C: new Test suite")]
    [Trait("Suite", "C")]
    public async Task TestMethod1()
    {
        await Task.Delay(100);
        Assert.True(true);
    }
    
    [Fact(DisplayName = "C: Exclude")]
    [Trait("Suite", "C")]
    public async Task TestMethod2()
    {
        await Task.Delay(100);
        Assert.True(true);
    }
}