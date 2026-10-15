for(int i = 0; i < 10; i++)
{
    TreeNode node = new TreeNode(i);
    Console.WriteLine($"Created node with value: {node.Value}");
}
NodeInformation.PrintNodeInfo(new TreeNode(5) { Left = new TreeNode(3), Right = new TreeNode(7) });


var currentPrintNode = new TreeNode(10);


NodeInformation.PrintNodeInfo(currentPrintNode);

