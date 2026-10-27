using BenchmarkDotNet.Attributes;
using ChallengeProblemSolution.TreeNodeFolder._700;

namespace ChallengeProblemBigO.TreeNode;

[ShortRunJob]
[MemoryDiagnoser]
public class Solution700
{
   
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
