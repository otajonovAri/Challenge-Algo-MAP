namespace ChallengeProblemSolution.Top_Interview_150;

public class Solution1
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        for (int i = 0; i < n; i++)
            nums1[m + 1] = nums2[i];
        
        Array.Sort(nums1);
    }

    private static void InsertMaxArray(int[] x, int[] y)
    {
        int counter = 0;
        for (int i = 0; i < x.Length; i++)
        {
            if (x[i] == 0 && counter < y.Length)
            {
                x[i] = y[counter];
                counter++;
            }
        }
    }
}