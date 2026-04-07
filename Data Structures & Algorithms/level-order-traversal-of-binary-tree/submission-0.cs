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
        // queue for level order

        if (root is null) {
            return new List<List<int>>();
        }

        var result = new List<List<int>>();
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while (queue.Count > 0) {
            var currentLevel = new List<int>();

            for (var levelCount = queue.Count; levelCount > 0; levelCount --) {
                var node = queue.Dequeue();
                currentLevel.Add(node.val);
                if (node.left is not null) {
                    queue.Enqueue(node.left);
                }
                if (node.right is not null) {
                    queue.Enqueue(node.right);
                }
            }

            if (currentLevel.Count > 0) {
                result.Add(currentLevel);
            }
        }

        return result;
    }
}
