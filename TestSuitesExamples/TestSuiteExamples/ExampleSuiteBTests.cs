namespace TestSuitesExamples;

[Collection("SuiteB")]
public class ExampleSuiteBTests
{
    [Fact(DisplayName = "B: health endpoint responds")]
    [Trait("Suite", "B")]
    public async Task Health_Responds()
    {
        Assert.False(false);
    }
    
    [Fact(DisplayName = "B: health endpoint responds")]
    [Trait("Suite", "B")]
    public async Task Exclude()
    {
        await Task.Delay(100);
        Assert.True(true);
    }
}