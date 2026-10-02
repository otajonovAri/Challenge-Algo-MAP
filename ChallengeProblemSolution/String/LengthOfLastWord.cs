public class LengthOfLastWordSolution
{
	// Trim , Split and return the length of the last word in the stirng.
	public int LengthOfLastWord(string s)
	{
		var splitWord = s.Trim(' ').Split(' ').ToList();

		return splitWord[^1].Length;
	}
}