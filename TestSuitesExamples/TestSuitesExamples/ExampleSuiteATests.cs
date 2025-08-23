namespace TestSuitesExamples;

[Collection("SuiteA")]
public class ExampleSuiteATests
{
    [Fact(DisplayName = "A: health endpoint responds")]
    [Trait("Suite", "A")]
    public async Task Health_Responds()
    {
        await Task.Delay(100);
        Assert.True(true);
    }
    
    [Fact(DisplayName = "A: Exclude")]
    [Trait("Suite", "A")]
    public async Task Exclude()
    {
        await Task.Delay(100);
        Assert.True(true);
    }
}