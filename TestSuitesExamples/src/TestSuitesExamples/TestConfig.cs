namespace TestSuitesExamples;

using System.Xml.Linq;

public sealed class TestConfig
{
    public int TimeoutSeconds { get; }
   

    private TestConfig(int timeoutSeconds)
    {
       
        TimeoutSeconds = timeoutSeconds;
       
    }

    public static TestConfig Load(string path)
    {
        var doc = XDocument.Load(path);
        var api = doc.Root?.Element("api");
        
        var timeout = (int?)api?.Attribute("timeoutSeconds") ?? 30;
       
        return new TestConfig(timeout);
    }
}
