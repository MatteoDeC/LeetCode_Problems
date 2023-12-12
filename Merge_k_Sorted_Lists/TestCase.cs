internal class TestCase
{
    public static void Test1()
    {
        ListNode list1 = new ListNode(5, new ListNode(4, new ListNode(1, null)));
        ListNode list2 = new ListNode(4, new ListNode(3, new ListNode(1, null)));
        ListNode list3 = new ListNode(6, new ListNode(2, null));
        ListNode[] lists = new ListNode[] { list1, list2, list3 };

        ListNode list = (new Solution()).MergeKLists(lists);

        while (list != null)
        {
            Console.Write(list.val + " ");
            list = list.next;
        }
    }
}
