/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    public bool IsValidBST(TreeNode root) {
        // range

        return valid(root, int.MinValue, int.MaxValue);
    }

    private bool valid(TreeNode node, int leftEdge, int rightEdge) {
        if (node is null) {
            return true;
        }

        if (!(node.val > leftEdge && node.val < rightEdge)) {
            return false;
        }

        return valid(node.left, leftEdge, node.val)
            && valid(node.right, node.val, rightEdge);
    }
}
