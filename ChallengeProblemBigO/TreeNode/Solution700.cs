using BenchmarkDotNet.Attributes;
using ChallengeProblemSolution.TreeNodeFolder._700;

namespace ChallengeProblemBigO.TreeNode;

[ShortRunJob]
[MemoryDiagnoser]
public class Solution700
{
    private readonly Solution _solution = new Solution();
    private TreeNode _smallNode;
    private TreeNode _middNode;
    private TreeNode _bigNode;

    [GlobalSetup]
    public void SetUp()
    {
        _smallNode = GenerationNode(10);
        _middNode = GenerationNode(100);
        _bigNode = GenerationNode(1000);
    }

    public TreeNode Get_smallNode1()
    {
        return _smallNode;
    }

    [Benchmark]
    public void Benchmark_SmallInput(TreeNode _smallNode1)
           => _solution.SearchBST(_smallNode1, 10);

    [Benchmark]
    public void Benchmark_MiddInput()
            => _solution.SearchBST(_middNode, 100);

    [Benchmark]
    public void Benchmark_BigInput()
           => _solution.SearchBST(_bigNode, 1000);
    private static TreeNode GenerationNode(int valInput)
    {
        var random = new Random();
        int val = random.Next(1, valInput);
        var generationNode = new TreeNode(val);
        return generationNode;
    }
}


public class TreeNode
{
    public int val { get; set; }
    public TreeNode left { get; set; }
    public TreeNode right { get; set; }

    public TreeNode(int val = 0 , TreeNode left = null , TreeNode right = null)
    {
        this.val = val;
        this.right = right;
        this.left = left;
    }
}
