using System.Numerics;

namespace ChallengeProblemSolution.LinkedList._006;

public class AddTwoNumbersSolution
{
    public ListNode AddTwoNumbers(ListNode l1 , ListNode l2)
    {
        var list1 = ListSumSplit(ConverterListNodeToList(l1));
        var list2 = ListSumSplit(ConverterListNodeToList(l2));
        var ab = SumBigIntegrsTwo(list1, list2);
        var list = SumBigIntegersConverterList(ab);

        var dummy = new ListNode();
        var curr = dummy;

        if (list.Count == 1 && list[0] == 0) return new ListNode(0);
        if (list.Count() - 1 > 1)
            list = list.Skip(1).ToList();

        foreach(var item in list)
        {
            curr.next = new ListNode(item);
            curr = curr.next;
        }

        return dummy;
    }

    private static List<int> SumBigIntegersConverterList(BigInteger ab)
    {
        var list = new List<int>();

        while(ab != 0)
        {
            list.Add((int)ab % 10);
            ab /= 10;
        }

        return list;
    }

    private static BigInteger SumBigIntegrsTwo(BigInteger a , BigInteger b)
        => (BigInteger)(a + b);

    private static BigInteger ListSumSplit(List<int> list)
    {
        BigInteger sum = BigInteger.Zero;
        var len = list.Count() - 1;

        foreach (var item in list){
            sum += item * (BigInteger)MathF.Pow(10, len);
            len--;
        }

        return sum;
    }
    
    private static List<int> ConverterListNodeToList(ListNode head)
    {
        var list = new List<int>();
        var curr = head;

        while(curr != null)
        {
            list.Add(curr.val);
            curr = curr.next;
        }

        return list;
    }
}
