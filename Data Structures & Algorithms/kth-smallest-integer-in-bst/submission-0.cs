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
    public int KthSmallest(TreeNode root, int k) {
        return dfs(root, k).Value;
    }

    private int _num = 0;
    private int? dfs(TreeNode root, int target) {
        if (root is null) {
            return null;
        }

        int? left = dfs(root.left, target);

        // NLR
        _num ++;
        if (_num == target) {
            return root.val;
        }

        int? right = dfs(root.right, target);

        return left is not null 
            ? left.Value 
            : right is not null 
                ? right.Value
                : null;
    }
}
