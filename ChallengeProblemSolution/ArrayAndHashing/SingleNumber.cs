namespace ChallengeProblemSolution.ArrayAndHashing;

public class SingleNumber
{
    // O(n) solution 
    public int SingleNumberSolowerON(int[] nums)
    {
        var singleNum = 0;
        foreach (var item in nums)
            singleNum ^= item;

         return singleNum;
    }

    // Dictionary Problem
    public int SingleNumberS(int[] nums)
    {
        var dict = GetDict(nums);

        foreach(var item in dict)
             if(item.Value == 1)
                   return item.Key;

        return -1;
    }

    public static Dictionary<int, int> GetDict(int[] nums)
    {
        var dict = new Dictionary<int, int>();
        foreach (var item in nums)
            dict[item] = dict.GetValueOrDefault(item, 0) + 1;

        return dict;
    }

}