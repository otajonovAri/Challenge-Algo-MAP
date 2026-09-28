namespace ChallengeProblemSolution.ArrayAndHashing;

public class HeightCheckerSolution
{
    // clone , sort , checking
    public int HeightChecker(int[] heights)
    {
        var sortedHeights = (int[])heights.Clone();
        Array.Sort(sortedHeights);
        int count = 0;
        for (int i = 0; i < heights.Length; i++)
        {
            if (heights[i] != sortedHeights[i])
            {
                count++;
            }
        }
        return count;
    }
}
