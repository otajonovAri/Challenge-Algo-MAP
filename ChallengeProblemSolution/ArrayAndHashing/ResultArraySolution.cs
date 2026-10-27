namespace ChallengeProblemSolution.ArrayAndHashing;

public class ResultArraySolution
{
    public int[] ResultArray(int[] nums)
    {
        var odd = new List<int>();
        var even = new List<int>();

        foreach (var item in nums)
        {
            if(item % 2 == 1)
                odd.Add(item);
            if(item % 2 == 0)
                even.Add(item);
        }
        
        return even.Concat(odd.OrderByDescending(x => x).ToList()).ToArray();
    }
}