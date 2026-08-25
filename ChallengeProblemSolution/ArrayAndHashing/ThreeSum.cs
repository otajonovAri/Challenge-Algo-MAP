namespace ChallengeProblemSolution.ArrayAndHashing;

public class ThreeSum
{
    public List<List<int>> ThreeSum(int[] nums)
    {
        if (nums.Length == 0) return new List<List<int>>(0);

        //if(nums.Length == 3)
        //{
        //    if (nums[0] + nums[1] + nums[2] == 0)
        //        return new List<List<int>> { new List<int> { nums[0], nums[1], nums[2] } };
        //    else
        //        return new List<List<int>>(0);
        //}

        var result = new List<List<int>>();

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                for (int k = j + 1; k < nums.Length; k++)
                {
                    if (nums[i] + nums[j] + nums[k] == 0)
                    {
                        result.Add(new List<int> { nums[i], nums[j], nums[k] });
                    }
                }
            }
        }

        return new List<List<int>>();
    }
}
