namespace ChallengeProblemSolution.String;

public class MaxNumberOFBalloonsSolution
{
    public int MaxNumberOfBalloons(string text)
    {
        var constStr = "abnlo";
        var dict = GetCharacterCounter(text);
        var values = new List<int>();

        foreach (var item in dict)
        {
            if (item.Key == 'l' || item.Key == 'o')
                values.Add(item.Value / 2);
            else
                values.Add(item.Value);
        }

        return GetDict(values).Max(x => x.Value);
    }
    private static Dictionary<int,int> GetDict(List<int> val)
    {
        var dict = new Dictionary<int, int>();
        foreach (var item in val)
            dict[item] = dict.GetValueOrDefault(item, 0) + 1;

        return dict;
    }
    private static Dictionary<char,int> GetCharacterCounter(string str)
    {
        var dict = new Dictionary<char, int>();
        foreach (var item in str)
            dict[item] = dict.GetValueOrDefault(item, 0) + 1;

        return dict;
    }
}
