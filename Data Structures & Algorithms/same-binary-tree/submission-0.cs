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
    public bool IsSameTree(TreeNode p, TreeNode q) {
        // if left tree are same, 
        // and right tree are same, 
        // and current val are same

        if (p is null && q is null) {
            return true;
        }

        if (p is null || q is null) {
            return false;
        }

        bool isLeftSame = IsSameTree(p.left, q.left);
        bool isRightSame = IsSameTree(p.right, q.right);

        return isLeftSame && isRightSame && p.val == q.val;
    }

}
