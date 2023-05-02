// See https://aka.ms/new-console-template for more information
using ProductionVersionExtractor;

class Program
{
    static void Main(string[] args)
    {
        var versionExtractor = new VersionExtractor();

        List<string> versions = new List<string> { "2.5.0-dev.1", "2.4.2-5354", "2.4.2-test.675", "2.4.1-integration.1" };

        string productionVersion = versionExtractor.GetProductionVersion(versions);
        Console.WriteLine(productionVersion);
    }
}
