using HackerRank;

namespace TestProject1;

public class UnitTest1
{
    
    private readonly HackerRankEasy _hackerRank = new();

    [Fact]
    public void SolveMeFirst_WhenAddingPositiveNumbers_ReturnsSum() => Assert.Equal(4, _hackerRank.solveMeFirst(2, 2));

    [Fact]
    public void SimpleArraySum_ReturnsSum()
    {
        var values = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9};

        var result = _hackerRank.simpleArraySum(values);
        
        Assert.Equal(45, result);
    }
}