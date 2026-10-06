namespace ChallengeProblemSolution.ArrayAndHashing;

public class FrequencySortSolution
{
    public int[] FrequencySort(int[] nums)
    {
        return nums;
    }
    private static Dictionary<int,int> GetDic(int[] nums)
    {
        var dict = new Dictionary<int, int>();
        foreach (var item in nums)
            dict[item] = dict.GetValueOrDefault(item, 0) + 1;
        return dict;
    }
}
