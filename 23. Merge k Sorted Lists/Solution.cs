/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode MergeKLists(ListNode[] lists) {
        
        if(lists == null || lists.Length == 0)
            return null;

        int last = lists.Length -1;
        while(last != 0)
        {
            int i = 0;
            int j = last;
            while(i < j)
            {
                lists[i] = MergeLists(lists[i], lists[j]);
                i++;
                j--;
            }

            if(i >= j)
                last = j;
        }   
        return lists[0];
    }

     public static ListNode MergeLists(ListNode a, ListNode b)
        {
            if(a== null)
                return b;
            if(b == null)
                return a;
            ListNode result;
            if(a.val <= b.val)
            {
                result = a;
                result.next = MergeLists(a.next, b);
            }
            else
            {
                result = b;
                result.next = MergeLists(a, b.next);
            }
            return result;
        }
}