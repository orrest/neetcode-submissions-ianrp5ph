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
    private int res = 0;

    public int DiameterOfBinaryTree(TreeNode root) {
        Dfs(root);
        return res;
    }

    public int Dfs(TreeNode root) {
        if (root is null) {
            return 0;
        }

        int leftMax = Dfs(root.left);
        int rightMax = Dfs(root.right);

// “根到叶最长” 本质上是“某个节点左边深度为 0，右边深度很大”的特例
        res = Math.Max(res, leftMax + rightMax);

        return Math.Max(leftMax, rightMax) + 1;
    }
}
