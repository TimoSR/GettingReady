using HackerRank;

namespace TestProject1;

public class UnitTestHackerRankEasy
{
    // Normally we would rely on an interface
    // But in our case with hackerRank this makes it easier
    private readonly HackerRankEasy _hackerRank = new();

    [Fact]
    public void SolveMeFirst_WhenAddingPositiveNumbers_ReturnsSum() => Assert.Equal(4, _hackerRank.solveMeFirst(2, 2));

    [Fact]
    public void SimpleArraySum_ReturnsSum()
    {
        var values = Enumerable.Range(1, 9).ToList();
        var result = _hackerRank.simpleArraySum(values);
        Assert.Equal(45, result);
    }

    [Fact]
    public void Test3()
    {
        var a = new List<int> { 1, 2, 3 };
        var b = new List<int> { 3, 2, 1 };
        const int expectedAlice = 1;
        const int expectedBob = 1;
        var expected = new List<int> { expectedAlice, expectedBob };
        var result = _hackerRank.compareTriplets(a, b);
        Assert.Equal(expected, result);
    }
    
    public static TheoryData<int[], int[], int[]> TestMatrix3 => new()
    {
        { [1, 2, 3], [3, 2, 1], [1, 1] },
        { [5, 6, 7], [3, 6, 10], [1, 1]},
        { [17, 28, 30], [99, 16, 8], [2, 1]},
    };

    [Theory]
    [MemberData(nameof(TestMatrix3))]
    public void CompareTriplets_Works3(int[] alice, int[] bob, int[] expected)
    {
        var result = _hackerRank.compareTriplets(alice.ToList(), bob.ToList());
        Assert.Equal(expected.ToList(), result);
    }
}