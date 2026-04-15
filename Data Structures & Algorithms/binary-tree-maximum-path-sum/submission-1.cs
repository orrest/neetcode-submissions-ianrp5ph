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
    int res = int.MinValue;

    public int MaxPathSum(TreeNode root) {
        Gain(root);
        return res;
    }

    private int Gain(TreeNode root) {
        if (root == null) return 0;

        // if greater than 0, then count
        int left = Math.Max(0, Gain(root.left));
        int right = Math.Max(0, Gain(root.right));

        // left + current + right could be max, so update
        res = Math.Max(res, root.val + left + right);

        // find the left/right path, current node is not root
        return root.val + Math.Max(left, right);
    }
}
