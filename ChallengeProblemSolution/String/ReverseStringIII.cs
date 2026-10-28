namespace ChallengeProblemSolution.String;

public class ReverseStringIII
{
    public string ReverseWords(string s)
    {
        var list = new List<string>();
        foreach (var item in s.Split(' ').ToList())
            list.Add(ReverseString(item));

        return string.Join(" ", list);
    }

    private static string ReverseString(string str)
    {
        var chars = str.ToCharArray();
        Array.Reverse(chars);

        return new string(chars);
    }
}
