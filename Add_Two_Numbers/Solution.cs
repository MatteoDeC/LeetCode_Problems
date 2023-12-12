public class Solution {
    public ListNode? AddTwoNumbers(ListNode l1, ListNode l2)
    {
        var stringedList1 = getString(l1);
        var stringedList2 = getString(l2);
        int maxLength = stringedList1.Length >= stringedList2.Length ? stringedList1.Length : stringedList2.Length;
        string result = "";
        int carriage = 0;

        for(int i = 0; i < maxLength; i++)
        {
            int sum = carriage;

            if (stringedList1.Length > i)
                sum += stringedList1[i] - '0';

            if (stringedList2.Length > i)
                sum += stringedList2[i] - '0';

            if (sum >= 10)
            {
                sum = sum - 10;
                carriage = 1;
            }
            else
                carriage = 0;

            result += sum;
        }
        if (carriage == 1)
            result += carriage;

        ListNode? tempList = null;
        for (int i = 1; i <= result.Length; i++){
            int n = result[result.Length - i] - '0';
            ListNode? l = new ListNode(n, tempList);
            tempList = l;
        }

        return tempList;
    }

    private string getString(ListNode? list)
    {
        string stringedList = "" + list?.val;
        list = list?.next;

        while (list != null)
        {
            stringedList += "" + list.val;
            list = list.next;
        }

        return stringedList;
    }
}