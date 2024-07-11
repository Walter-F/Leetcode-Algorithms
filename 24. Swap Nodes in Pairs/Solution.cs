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
public class Solution
{
    public ListNode SwapPairs(ListNode head) {
        ListNode slow = head;
        ListNode fast = head;
        
        while(slow != null && slow.next != null)
        {
            fast = slow.next;
            (fast.val,slow.val) = (slow.val,fast.val);
            slow = fast.next;
        }
        return head;
    }
}