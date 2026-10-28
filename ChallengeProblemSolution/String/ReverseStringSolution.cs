namespace ChallengeProblemSolution.String;

public class ReverseStringSolution
{
    public void ReverseString(char[] s)
    {
        // easy solution 
        //Array.Sort(s);


        // dynamic solution
        int left = 0, right = s.Length - 1;

        var temp = '\0';

        while(left < right)
        {
            temp = s[left];
            s[left] = s[right];
            s[right] = temp;
            left++;
            right--;
        }
    }
}
