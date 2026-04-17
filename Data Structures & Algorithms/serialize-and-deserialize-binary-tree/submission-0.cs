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

public class Codec {

    // dfs to serialize, then dfs to deserialize

    // Encodes a tree to a single string.
    public string Serialize(TreeNode root) {
        dfs1(root);
        return string.Join(",", sb1);
    }

    private List<string> sb1 = new();
    private void dfs1(TreeNode root) {
        if (root is null) {
            sb1.Add("N");
            return;
        }
        // serialize self
        sb1.Add(root.val.ToString());

        // serialize left
        dfs1(root.left);

        // serialize right
        dfs1(root.right);
    }

    // Decodes your encoded data to tree.
    public TreeNode Deserialize(string data) {
        if (string.IsNullOrEmpty(data)) {
            return null;
        }

        string[] vals = data.Split(",");
        return dfs2(vals);
    }
    private int index = 0;
    private TreeNode dfs2(string[] vals) {
        if (index >= vals.Length) {
            return null;
        }

        string currentVal = vals[index ++];
        if (currentVal == "N") {
            return null;
        }

        int val = int.Parse(currentVal);
        var node = new TreeNode(val);
        node.left = dfs2(vals);
        node.right = dfs2(vals);

        return node;
    }
}
