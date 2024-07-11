/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode() {}
 *     ListNode(int val) { this.val = val; }
 *     ListNode(int val, ListNode next) { this.val = val; this.next = next; }
 * }
 */
class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        int size = 0;
        ListNode curr = head;

        //Calculates the size and deducts n from size
        for(ListNode temp = head; temp != null; temp = temp.next) size++;
        size-=n;

        //Defining base case
        if(size == 0) return head.next;

        //Iterating till the prev node
        for(int i = 0; i < size - 1; i++) curr = curr.next;
        
        //Skipping the next node
        curr.next = curr.next != null? curr.next.next : null;
        
        return head;
    }
}