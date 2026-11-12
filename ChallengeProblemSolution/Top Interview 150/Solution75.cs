namespace ChallengeProblemSolution.Top_Interview_150;

public class Solution75
{
    public bool SearchMatrix(int[][] matrix, int target)
    {
        for(int i = 0; i < matrix.Length; i++)
            for(int j = i ; j < matrix[i].Length; j++)
                if(matrix[i][j] == target)
                    return true;
        
        return false;
    }
}