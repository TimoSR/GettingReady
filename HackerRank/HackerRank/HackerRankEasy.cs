namespace HackerRank;

public class HackerRankEasy
{
    public int solveMeFirst(int a, int b)
    {
        return a + b;
    }

    public int simpleArraySum(List<int> ar)
    {
        int sum = 0;

        foreach (var value in ar)
        {
            sum += value;
        }
        
        return sum;
    }

    public List<int> compareTriplets(List<int> a, List<int> b)
    {
        var alicePoint = 0;
        var bobPoint = 0;

        var numberOfPoints = a.Count;

        for (var i = 0; i < numberOfPoints; i++)
        {
            if (a[i] > b[i])
            {
                alicePoint += 1;
            }
            else if (a[i] < b[i])
            {
                bobPoint += 1;
            }
        }

        return [alicePoint, bobPoint];
    }
}