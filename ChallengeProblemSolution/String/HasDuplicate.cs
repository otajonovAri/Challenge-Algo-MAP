namespace ChallengeProblemSolution.String;

public class HasDuplicate
{
    public bool hasDuplicate(int[] nums)
    {
        var len = nums.Length;
        return nums.Distinct().Count() != len;
    }
}
