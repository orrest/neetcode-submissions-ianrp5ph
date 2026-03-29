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
    public ListNode ReverseKGroup(ListNode head, int k) {
        // stack, size k,
        // push while stack is not full
        // if full, pop, reverse, set current pointer to next k start
        ListNode dummy = new();
        ListNode dCurrent = dummy;
        ListNode current = head;

        Stack<ListNode> stack = new (k);

        while (current is not null) {
            while (stack.Count < k && current is not null) {
                stack.Push(current);
                current = current.next;
            }

            if (stack.Count == k) {
                while (stack.Count > 0) {
                    ListNode node = stack.Pop();
                    node.next = null;
                    dCurrent.next = node;
                    dCurrent = dCurrent.next;
                }
                dCurrent.next = current;
            }
        }

        return dummy.next;
    }
}
