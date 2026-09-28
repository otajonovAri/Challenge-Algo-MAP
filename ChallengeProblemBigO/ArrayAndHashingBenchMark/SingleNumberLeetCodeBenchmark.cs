using BenchmarkDotNet.Attributes;
using ChallengeProblemSolution.ArrayAndHashing;

namespace ChallengeProblemBigO.ArrayAndHashingBenchMark;

[MemoryDiagnoser]
[ShortRunJob]
public class SingleNumberLeetCodeBenchmark
{
    private readonly SingleNumberLeetCode _solution = new SingleNumberLeetCode();

    private int[] easy;
    private int[] midd;
    private int[] ints;

    [GlobalSetup]
    public void Setup()
    {
        easy = new int[] { 2, 2, 1 };
        midd = new int[] { 4, 1, 2, 1, 2 };
        ints = new int[] { 1 };
    }

    [Benchmark(Description = "Easy")]
    public int SingleNumberEasy()
    {
        return _solution.SingleNumber(easy);
    }

    [Benchmark(Description = "Easy")]
    public int SingleNumberEasyLinq()
    {
        return _solution.SingleNumber(easy);
    }

    [Benchmark(Description = "Easy - HashSet")]
    public int SingleNumberEasyHashSet()
    {
        return _solution.SingleNumberHashSet(easy);
    }


    [Benchmark(Description = "Medium")]
    public int SingleNumberMedium()
    {
        return _solution.SingleNumber(midd);
    }

    [Benchmark(Description = "Medium")]
    public int SingleNumberMediumLinq()
    {
        return _solution.SingleNumberLinq(midd);
    }

    [Benchmark(Description = "Medium - HashSet")]
    public int SingleNumberMediumHashSet()
    {
        return _solution.SingleNumberHashSet(midd);
    }

    [Benchmark(Description = "Hard")]
    public int SingleNumberHard()
    {
        return _solution.SingleNumber(ints);
    }

    [Benchmark(Description = "Hard")]
    public int SingleNumberHardLinq()
    {
        return _solution.SingleNumberLinq(ints);
    }

    [Benchmark(Description = "Hard")]
    public int SingleNumberHardHashSet()
    {
        return _solution.SingleNumberHashSet(ints);
    }
}
