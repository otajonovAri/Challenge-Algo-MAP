namespace ChallengeProblemSolution.Math;

// Accept

public class MirrorDistanceSolution
{
    public int MirrorDistance(int n)
    {
        return System.Math.Abs(n - GetReverseNumber(n));
    }

    private static int GetReverseNumber(int n)
    {
        var result = 0;
        while (n != 0)
        {
            result = result * 10 + (n % 10);
            n /= 10;
        }
        return result;
    }
}