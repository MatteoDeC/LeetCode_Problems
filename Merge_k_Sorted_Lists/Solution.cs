internal class Solution
{
    public ListNode MergeKLists(ListNode[] lists)
    {
        List<int> vals = new List<int>();
        ListNode completeList = null;
        foreach (var list in lists)
        {
            var tempList = list;
            while (tempList != null)
            {
                vals.Add(tempList.val);
                tempList = tempList.next;
            }
        }
        vals = vals.OrderByDescending(i => i).ToList();
        foreach (int val in vals)
        {
            completeList = new ListNode(val, completeList);
        }

        return completeList;
    }
}