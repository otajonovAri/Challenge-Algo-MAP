namespace ChallengeProblemSolution.LinkedList.Reorder_Linked_List;

public class Solution
{
    public void ReorderList(ListNode head)
    {
        var list = new List<int>();
        GetListConverter(list, head);
        int left = 0, right = list.Count() - 1;
        var curr = head;

        while (left <= right)
        {
            curr.val = list[left];
            curr = curr.next;
            if (left != right)
            {
                curr.val = list[right];
                curr = curr.next;
            }

            left++; right--;
        }
    }

    private static void GetListConverter(List<int> list, ListNode head)
    {
        while (head != null)
        {
            list.Add(head.val);
            head = head.next;
        }
    }
}
