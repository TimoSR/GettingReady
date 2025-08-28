using Xunit.Abstractions;

namespace TestProject1;

public class UnitestHackerRankMedium(ITestOutputHelper testOutputHelper)
{
    [Fact]
    public void Test1()
    {
        //Can be seen from the tests section
        testOutputHelper.WriteLine("Hello World!");
    }
}