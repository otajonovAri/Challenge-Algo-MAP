namespace ChallengeProblemSolution.LinkedList.ReorderList;

public class ReorderListSolution
{
    public void ReorderList(ListNode head)
    {
        var list = new List<int>();
        GetListConverterHead(head, list);
    }

    private static void GetListConverterHead(ListNode head, List<int> list)
    {
        var curr = head;
        while (curr != null)
        {
            list.Add(curr.val);
            curr = curr.next;
        }
    }
}