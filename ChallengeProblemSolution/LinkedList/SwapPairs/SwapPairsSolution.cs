using ChallengeProblemSolution.LinkedList.Remove_Duplicates_from_Sorted_List;

namespace ChallengeProblemSolution.LinkedList.SwapPairs;

public class SwapPairsSolution
{
    public ListNode SwapPairs(ListNode head)
    {
        var even = EvenNumbers(head);
        var odd = OddNumbers(head);

        for(int i = 0; i < MathF.Min(even.Count() , odd.Count()); i++)
        {

        }
    }
    private static List<int> OddNumbers(ListNode head)
    {
        var list = new List<int>();
        var curr = head;

        while(curr != null)
        {
            if (curr.val % 2 == 1)
                list.Add(curr.val);

            curr = curr.next;
        }

        return list;
    }
    private static List<int> EvenNumbers(ListNode head)
    {
        var list = new List<int>();
        var curr = head;

        while (curr != null)
        {
            if (curr.val % 2 == 0)
                list.Add(curr.val);

            curr = curr.next;
        }

        return list;
    }
}
