namespace ChallengeProblemSolution.LinkedList.Delete_Nodes_From_Linked_List_Present_in_Array;

public class ModifiedListSolution
{
    public ListNode ModifiedList(int[] nums, ListNode head)
    {

        var set = new HashSet<int>(nums);
        var dummy = new ListNode(0);
        var curr = dummy;

        while (head != null)
        {
            if (!set.Contains(head.val))
            {
                curr.next = new ListNode(head.val);
                curr = curr.next;
            }
            head = head.next;
        }

        return dummy.next;
    }
}
