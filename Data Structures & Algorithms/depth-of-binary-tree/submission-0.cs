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
    public int MaxDepth(TreeNode root) {
        if (root is null) {
            return 0;
        }

        // left tree max depth
        int leftMax = MaxDepth(root.left);
        // right tree max depth
        int rightMax = MaxDepth(root.right);

        return Math.Max(leftMax, rightMax) + 1;
    }

}
