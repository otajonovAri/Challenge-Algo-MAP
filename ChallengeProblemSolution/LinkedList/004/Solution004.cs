namespace ChallengeProblemSolution.LinkedList._004;

public class Solution
{
    public void ReorderList(ListNode head)
    {
        Console.WriteLine(string.Join("->", ValueKeyPair(head)));
    }

    /// return list of values in the linked list
    private static List<int> ValueKeyPair(ListNode head)
    {        var list = new List<int>();
        var curr = head;

        while(curr != null)
        {
            list.Add(curr.val);
            curr = curr.next;
        }

        return list; 

    }
}
