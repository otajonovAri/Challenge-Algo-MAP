namespace ChallengeTesting.StringTest;

public class LengthOfLastWordLab
{
    private readonly LengthOfLastWordSolution _lengthOfLastWord
        = new LengthOfLastWordSolution();

    [Fact]
    public void LengthOfLastWord_ReturnsCorrectLength()
    {
        var result = _lengthOfLastWord.LengthOfLastWord("Hello World");
        Assert.Equal(5 , 
            result);
    }
}
