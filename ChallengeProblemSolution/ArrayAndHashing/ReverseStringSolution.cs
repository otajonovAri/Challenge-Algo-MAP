namespace ChallengeProblemSolution.ArrayAndHashing;

public class ReverseStringSolution
{
    public void ReverseString(char[] s)
    {
        int index = 0;

        for(int i = s.Length - 1; i >= 0; i--)
        {
            s[index++] = s[i];
        }
    }
}
