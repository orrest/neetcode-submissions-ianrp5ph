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
    private List<int> _view = [];

    public List<int> RightSideView(TreeNode root) {
        dfs(root, 0);

        return _view;
    }

    private void dfs(TreeNode root, int depth) {
        if (root is null) {
            return;
        }

        // the first time to a new depth,
        // the node of the first time is the right most.
        if (_view.Count == depth) {
            _view.Add(root.val);
        }

        dfs(root.right, depth + 1);
        dfs(root.left, depth + 1);
    }
}
