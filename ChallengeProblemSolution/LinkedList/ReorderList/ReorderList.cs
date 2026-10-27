namespace ChallengeProblemSolution.LinkedList.ReorderList;

public class ReorderListSolution
{
    public void ReorderList(ListNode head)
    {
        var list = new List<int>();
        GetListConverterHead(head , list);
        var sortList = SortingOddNextEven(list).DistinctBy(x => x).ToList();

        Console.WriteLine(string.Join("->", sortList));
        
        foreach (var item in sortList)
        {
            head.val = item;
            head = head.next;
        }
        
        // accept 125 ms
    }

    private static List<int> SortingOddNextEven(List<int> list)
    {
        int start = 0, end = list.Count - 1;
        var resList = new List<int>();

        while (start <= end)
        {
            resList.Add(list[start]);
            resList.Add(list[end]);
            start++;
            end--;
        }

        return resList;
    }
    
    private static void GetListConverterHead(ListNode head, List<int> list)
    {
        var curr = head;
        while (curr != null)
        {
            list.Add(curr.val);
            curr = curr.next;
        }
        
        list.Sort();
    }
}