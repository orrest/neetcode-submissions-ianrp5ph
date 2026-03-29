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
    public ListNode MergeTwoLists(ListNode head1, ListNode head2) {
        ListNode dummy = new ListNode();
        ListNode current = dummy;
        ListNode node1 = head1;
        ListNode node2 = head2;
        while (node1 is not null && node2 is not null) {
            if (node1.val < node2.val) {
                current.next = node1;
                node1 = node1.next;
            } else {
                current.next = node2;
                node2 = node2.next;
            }
            current = current.next;
        }

        if (node1 is not null) {
            current.next = node1;
        }

        if (node2 is not null) {
            current.next = node2;
        }
        

        return dummy.next;
    }
}