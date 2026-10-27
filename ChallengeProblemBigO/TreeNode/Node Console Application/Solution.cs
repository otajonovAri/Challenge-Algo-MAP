namespace ChallengeProblemBigO.TreeNode.Node_Console_Application;

public class Solution
{
    public static void GetNodeValueInsert()
    {
        var root = new TreeNode(10);
        var five = new TreeNode(20);
        var fiften = new TreeNode(15);

        root.Left = five;
        root.Right = fiften;
        root.Parent = root;

        fiften.Parent = root;
    }

    public static void PrintTree(TreeNode? node)
    {
        if (node == null)
            return;

        Console.WriteLine(node.Value);

        PrintTree(node.Left);
        PrintTree(node.Right);
    }
}
