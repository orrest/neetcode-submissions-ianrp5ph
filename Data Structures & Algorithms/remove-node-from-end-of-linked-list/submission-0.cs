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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        // total length
        ListNode cur = head;
        int length = 0;
        while (cur is not null) {
            length ++;
            cur = cur.next;
        }

        // forward ith > length || < 0
        int index = length - n; // from 0
        if (index < 0 || index > length-1) {
            return head;
        }

        int i = 0;
        ListNode prev = null;
        ListNode node = head;
        while (node is not null) {
            if (i == index) {
                break;
            }
            i ++;
            prev = node;
            node = node.next;
        }

        // (i-1).next = i+1
        // i.next = null
        if (prev is not null) {
            prev.next = node.next;
            node.next = null;
            return head;
        } else {
            head = node.next;
            node.next = null;
            return head;
        }
    }
}
