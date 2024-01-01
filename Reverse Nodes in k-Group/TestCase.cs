internal class TestCase
{
    public static void Test1()
    {
        ListNode list1 = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5, null)))));

        ListNode list = (new Solution()).ReverseKGroup(list1, 2);

        while (list != null)
        {
            Console.Write(list.val + " ");
            list = list.next;
        }
        Console.WriteLine();
    }
    public static void Test2()
    {
        ListNode list1 = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5, null)))));

        ListNode list = (new Solution()).ReverseKGroup(list1, 3);

        while (list != null)
        {
            Console.Write(list.val + " ");
            list = list.next;
        }
        Console.WriteLine();
    }
    public static void Test3()
    {
        ListNode list1 = new ListNode(1, new ListNode(2, null));

        ListNode list = (new Solution()).ReverseKGroup(list1, 2);

        while (list != null)
        {
            Console.Write(list.val + " ");
            list = list.next;
        }
        Console.WriteLine();
    }
}
