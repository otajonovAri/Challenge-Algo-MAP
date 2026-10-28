namespace ChallengeProblemSolution.ArrayAndHashing;

public class MergeSolution
{
    public void Merge(int[] nums1 , int m , int[] nums2 , int n)
    {
        // [10,20,20,40,0,0] = 6
        // m = 4 

        // [1,2] = 2;
        // n = 2

        var index = 0;
        while(index <= n)
        {
            nums1[(m - 1) + index] = nums2[index];
            index++;
        }

        Console.WriteLine(string.Join("," , nums1));
    }
}
