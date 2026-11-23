namespace ChallengeProblemSolution.ArrayAndHashing;

public class IntersectionSolution
{
    public IList<int> Intersection(int[][] nums)
    {
        var dict = new Dictionary<int, int>();
        var len = nums.Length;
        
        foreach(var item in nums)
            GetDictionaryCounterFunc(item, dict);
        
        var list = new List<int>();
        
        foreach(var item in dict)
            if(item.Value % len == 0)
                list.Add(item.Key);
        
        list.Sort();
        
        return list;
    }

    private static void GetDictionaryCounterFunc(int[] nums, Dictionary<int, int> dict)
    {
        foreach (var item in nums)
            dict[item] = dict.GetValueOrDefault(item, 0) + 1;
    }
}