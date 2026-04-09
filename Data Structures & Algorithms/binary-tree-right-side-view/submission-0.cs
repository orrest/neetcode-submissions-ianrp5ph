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
    public List<int> RightSideView(TreeNode root) {
        // level order, the last on current level
        if (root is null) {
            return new List<int>();
        }

        var res = new List<int>();

        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while (queue.Count > 0) {

            for (var i = queue.Count; i > 0; i --) {
                var node = queue.Dequeue();
                if (i == 1) {
                    res.Add(node.val);
                }

                if (node.left is not null) {
                    queue.Enqueue(node.left);
                }

                if (node.right is not null) {
                    queue.Enqueue(node.right);
                }
            }

        }

        return res;
    }
}
