using BenchmarkDotNet.Attributes;

namespace ChallengeProblemBigO.StringBenchMark;

[ShortRunJob]
[MemoryDiagnoser]
public class LengthOfLastWordBench
{
    private readonly LengthOfLastWordSolution _lengthOfLastWord
        = new LengthOfLastWordSolution();
    private string _smallInput;
    private string _mediumInput;
    private string _largeInput;
    [GlobalSetup]
    public void Setup()
    {
        _smallInput = "Hello World";
        _mediumInput = new string('a', 1000) + " " + new string('b', 1000);
        _largeInput = new string('a', 100000) + " " + new string('b', 100000);
    }
    [Benchmark]
    public void Benchmark_SmallInput()
        => _lengthOfLastWord.LengthOfLastWord(_smallInput);
    [Benchmark]
    public void Benchmark_MediumInput()
        => _lengthOfLastWord.LengthOfLastWord(_mediumInput);
    [Benchmark]
    public void Benchmark_LargeInput()
        => _lengthOfLastWord.LengthOfLastWord(_largeInput);
}
