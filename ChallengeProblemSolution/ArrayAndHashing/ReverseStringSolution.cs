namespace ChallengeProblemSolution.ArrayAndHashing;

public class ReverseStringSolution
{
    public void ReverseString(char[] s)
    {
        var chars = s.ToString();
        var index = 0;
        foreach (var item in chars)
            s[index++] = item;
    }
}
