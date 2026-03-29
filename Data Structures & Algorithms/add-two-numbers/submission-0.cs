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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        
        int step = 0;
        ListNode dummy = new();
        ListNode current = dummy;

        while (l1 is not null && l2 is not null) {
            int val = (l1.val + l2.val + step) % 10;
            step = (l1.val + l2.val + step) / 10;
            current.next = new ListNode(val);
            current = current.next;
            l1 = l1.next;
            l2 = l2.next;
        }

        while (l1 is not null) {
            int val = (l1.val + step) % 10;
            step = (l1.val + step) / 10;
            current.next = new ListNode(val);
            current = current.next;
            l1 = l1.next;
        }

        while (l2 is not null) {
            int val = (l2.val + step) % 10;
            step = (l2.val + step) / 10;
            current.next = new ListNode(val);
            current = current.next;
            l2 = l2.next;
        }

        if (step != 0) {
            current.next = new ListNode(step);
        }

        return dummy.next;
    }
}
