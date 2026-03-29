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
    public ListNode MergeKLists(ListNode[] heads) {
        
        heads = heads.Where(h => h is not null).ToArray();

        ListNode dummy = new();
        ListNode current = dummy;

        while (heads.Length > 0) {

            // find current min val node
            int minValIndex = 0;
            ListNode minValNode = heads[minValIndex];
            for (int i = 1; i < heads.Length; i++) {
                ListNode head = heads[i];
                if (head.val <= minValNode.val) {
                    minValNode = head;
                    minValIndex = i;
                }
            }

            // update head in list to next
            ListNode next = minValNode.next;
            heads[minValIndex] = next;

            // record to result list
            minValNode.next = null;
            current.next = minValNode;
            current = current.next;

            // update heads
            heads = heads.Where(h => h is not null).ToArray();
        }

        return dummy.next;
    }
}
