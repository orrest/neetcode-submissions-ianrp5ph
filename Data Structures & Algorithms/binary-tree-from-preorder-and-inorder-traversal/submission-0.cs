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
    private Dictionary<int, int> inorderValIdx = new();

    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        if (preorder is null || inorder is null) {
            return null;
        }

        for (int i = 0; i < inorder.Length; i++){
            inorderValIdx[inorder[i]] = i;
        }

        return dfs(preorder, 0, inorder.Length - 1);
    }
    private int currentPreIdx = 0;
    private TreeNode dfs(int[] preorder, int l, int r) {
        if (l > r) {
            return null;
        }

        int val = preorder[currentPreIdx++];
        var root = new TreeNode(val);
        int inorderMidIdx = inorderValIdx[val];
        root.left = dfs(preorder, l, inorderMidIdx - 1);
        root.right = dfs(preorder, inorderMidIdx + 1, r);

        return root;
    }
}
