using Xunit.Abstractions;

namespace TestProject1;

public class UnitestHackerRankMedium(ITestOutputHelper testOutputHelper)
{
    [Fact]
    public void Test1()
    {
        testOutputHelper.WriteLine("Hello World!");
    }
}