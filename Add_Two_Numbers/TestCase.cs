public static class TestCase{
    public static void Test1()
    {
        ListNode list1 = new ListNode(2, new ListNode(4, new ListNode(3, null)));
        ListNode list2 = new ListNode(5, new ListNode(6, new ListNode(4, null)));

        var list = (new Solution()).AddTwoNumbers(list1, list2);

        while (list?.next != null)
        {
            Console.Write(list.val);
            list = list.next;
        }
        Console.Write(list?.val + "\n");
    }

    public static void Test2()
    {
        ListNode list1 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, null)))))));
        ListNode list2 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, null))));

        var list = (new Solution()).AddTwoNumbers(list1, list2);

        while (list?.next != null)
        {
            Console.Write(list.val);
            list = list.next;
        }
        Console.Write(list?.val + "\n");
    }

    public static void Test3()
    {
        ListNode list1 = new ListNode(9, null);
        ListNode list2 = new ListNode(1, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(8, new ListNode(9, new ListNode(9, new ListNode(9, null))))))))));

        var list = (new Solution()).AddTwoNumbers(list1, list2);

        while (list?.next != null)
        {
            Console.Write(list.val);
            list = list.next;
        }
        Console.Write(list?.val + "\n");
    }
}