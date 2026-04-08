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
    public List<List<int>> LevelOrder(TreeNode root) {
        var result = new List<List<int>>();
        dfs(result, root, 1);
        return result;
    }

    private void dfs(List<List<int>> res, TreeNode root, int level) {
        if (root is null) {
            return;
        }

        if (level > res.Count) {
            res.Add(new List<int>());
        }

        res[level-1].Add(root.val);

        dfs(res, root.left, level + 1);
        dfs(res, root.right, level + 1);
    }

    // bfs is level order, use queue
    // dfs is recursive, use timing, NLR, from left to right
}
