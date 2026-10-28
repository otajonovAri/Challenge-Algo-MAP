namespace ChallengeProblemBigO.TreeNode.Node_Console_Application;

public class TreeNode
{
    public int Value { get; set; }

    public TreeNode? Left { get; set; }
    public TreeNode? Right { get; set; }
    public TreeNode? Parent { get; set; }

    public TreeNode(int value)
    {
        Value = value;
    }
}
