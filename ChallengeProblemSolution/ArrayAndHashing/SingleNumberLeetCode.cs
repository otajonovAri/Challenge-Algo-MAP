namespace ChallengeProblemSolution.ArrayAndHashing;

public class SingleNumberLeetCode
{
    public int SingleNumber(int[] nums)
    {
        var x = 0;
        foreach (var item in nums)
            x ^= item;
        return x;
    }

    // Solution using LINQ
    public int SingleNumberLinq(int[] nums)
        => nums.GroupBy(x => x).Where(g => g.Count() == 1).Select(g => g.Key).FirstOrDefault();

    // Solution using HashSet
    public int SingleNumberHashSet(int[] nums)
    {
        var dict = new Dictionary<int, int>();
        foreach (var item in nums)
            dict[item] = dict.GetValueOrDefault(item, 0) + 1;

        return dict.Where(kv => kv.Value == 1).Select(kv => kv.Key).FirstOrDefault();
    }
}
