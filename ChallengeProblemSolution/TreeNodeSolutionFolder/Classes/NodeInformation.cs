public class NodeInformation
{
    public static void PrintNodeInfo(TreeNode? node)
    {
        if(node == null) return;

        PrintNodeInfo(node?.Left);
        Console.WriteLine($"Node Value: {node?.Value}");
        PrintNodeInfo(node?.Right);
    }   
}