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
    public ListNode ReverseList(ListNode head) {
        if (head is null) {
            return null;
        }

        ListNode prev = null;
        ListNode cur = head;
        ListNode next = cur.next;

        while (next is not null) {
            cur.next = prev;
            prev = cur;
            cur = next;
            next = cur.next;
        }

        cur.next = prev;

        return cur;
    }
}
