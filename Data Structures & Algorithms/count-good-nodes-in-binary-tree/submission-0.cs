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
    public int GoodNodes(TreeNode root) {
        // if the node val is the biggest val
        // among values on its path, then the node 
        // is considered good node

        dfs(root, root.val);
        
        return _good;
    }

    private int _good = 0;
    private void dfs(TreeNode root, int pathMax) {
        if (root is null) {
            return;
        }

        int currentMax = pathMax;
        if (root.val >= pathMax) {
            _good ++;
            currentMax = root.val;
        }

        dfs(root.left, currentMax);
        dfs(root.right, currentMax);
    }
}
