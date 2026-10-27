namespace ChallengeProblemSolution.ArrayAndHashing;

public class FirstUniqueCharSolution
{
    public int FirstUniqueChar(string s)
    {
        var dict = GetDict(s);
        foreach(var item in dict)
            if(item.Value == 1)
                return s.IndexOf(item.Key);

        return -1;
    }

    private static Dictionary<char, int> GetDict(string str)
    {
        var dict = new Dictionary<char, int>();
        foreach (var item in str)
            dict[item] = dict.GetValueOrDefault(item, 0) + 1;
        return dict;
    }
}