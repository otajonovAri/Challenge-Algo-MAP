namespace ChallengeProblemSolution.List;

public class CombinationSum22
{
    public List<List<int>> CombinationSum2(int[] candidates, int target)
    {
        var result = new List<List<int>>();

        for(int i = 0; i < candidates.Length; i++)
        {
            var currentCombination = new List<int>();
            int currentSum = candidates[i];
            currentCombination.Add(candidates[i]);


            for (int j = i; j < candidates.Length; j++)
            {
                currentSum += candidates[j];
                currentCombination.Add(candidates[j]);

                if(currentSum == target)
                {
                    result.Add(new List<int>(currentCombination));
                    break;
                }
                else if (currentSum > target)
                {
                    break;
                }
            }
        }

        return result;
    }
}
