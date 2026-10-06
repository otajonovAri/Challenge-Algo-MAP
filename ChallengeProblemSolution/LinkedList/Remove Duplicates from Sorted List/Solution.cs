namespace ChallengeProblemSolution.LinkedList.Remove_Duplicates_from_Sorted_List;

public class Solution
{
    public ListNode DeleteDuplicates(ListNode head)
    {
        var dummy = new ListNode(0);
        var curr = dummy;

        foreach(var item in GetHashSet(head))
        {
            curr.next = new ListNode(item);
            curr = curr.next;
        }

        return dummy.next;
    }

    private static HashSet<int> GetHashSet(ListNode head)
    {
        var set = new HashSet<int>();
        var curr = head;

        while(curr != null)
        {
            set.Add(curr.val);
            curr = curr.next;
        }

        return set;
    }
}
