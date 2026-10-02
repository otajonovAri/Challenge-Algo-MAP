namespace ChallengeProblemSolution.ArrayAndHashing;

public class GetConcatenation
{
    // Solution - 1
    public int[] GetConcatenationFunc(int[] nums)
    {
        var res = new int[nums.Length * 2];
        for(int i = 0; i < nums.Length; i++)
        {
            res[i] = nums[i];
            res[nums.Length - 1 + i] = nums[i];
        }

        return res;
    }

    // Solution - 2
    public int[] GetConcatenation2(int[] nums)
        => nums.Concat(nums).ToArray();

    // Solution - 3
    public int[] GetConcatenation3(int[] nums)
    {
        var list = new List<int>();
        GetAddingNumbers(nums, list); // First Range
        GetAddingNumbers(nums, list); // Dublication Range
        return list.ToArray();
    }
    private static void GetAddingNumbers(int[] nums , List<int> list)
    {
        foreach (var item in nums)
            list.Add(item);
    }

}
