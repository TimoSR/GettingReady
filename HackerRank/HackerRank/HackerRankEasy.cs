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
}