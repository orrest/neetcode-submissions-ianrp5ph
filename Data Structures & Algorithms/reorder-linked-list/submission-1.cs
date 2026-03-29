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
    public void ReorderList(ListNode head) {
        Dictionary<int, ListNode> dict = new();

        ListNode p = head;
        int i = 0;
        while (p is not null){
            dict[i ++] = p;
            p = p.next;
        }

        ListNode sortedEnd = head;
        int forward = 0, backward = i - 1;
        while (forward < backward) {
            ListNode n1 = dict[forward];
            ListNode n2 = dict[backward];
            n1.next = n2;
            if (sortedEnd != head) {
                sortedEnd.next = n1;   
            }
            sortedEnd = n2;
            n2.next = null;

            forward ++;
            backward --;
        }

        if (forward == backward) {
            ListNode n = dict[forward];
            sortedEnd.next = n;
            n.next = null;
        }
    }
}
