namespace ChallengeProblemSolution.LinkedList.Merge_Nodes_in_Between_Zeros;

public class MergeNodesSolution
{
    public ListNode MergeNodes(ListNode head)
    {
        var dummy = new ListNode(0);
        var curr = dummy;
        foreach(var item in GetListZerosSum(head))
        {
            curr.next = new ListNode(item);
            curr = curr.next;
        }

        return dummy.next;
    }
    private static List<int> GetListZerosSum(ListNode head)
    {
        var list = new List<int>();
        var sum = 0;
        var curr = head;

        while(curr != null)
        {
            if(curr.val == 0 && sum != 0)
            {
                list.Add(sum);
                sum = 0;
            } else
            {
                sum += curr.val;
                curr = curr.next;
            }
        }

        return list;
    }
}
