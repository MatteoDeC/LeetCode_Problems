using System.Runtime.CompilerServices;

internal class Solution
{
    public ListNode ReverseKGroup(ListNode head, int k)
    {
        int key = 0;
        var dict = new Dictionary<int, ListNode>();

        ListNode? tempNode = head;
        while (tempNode != null)
        {
            dict.Add(key, tempNode);
            tempNode = tempNode.next;
            key++;
        }

        int iterations = dict.Count / k;
        for (int i = 0; i < iterations; i++)
        {
            for (int j = 0; j < k / 2; j++)
            {
                var temp = dict[j + (i*k)];
                dict[j + (i * k)] = dict[(i * k) +k - 1 - j];
                dict[(i * k) +k - 1 - j] = temp;
            }
        }

        for (int i = 0; i < dict.Count-1; i++)
        {
            dict[i].next = dict[i + 1];
        }
        dict[dict.Count-1].next = null;

        return dict[0];
    }
}