/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node copyRandomList(Node head) {

        // node -> [random -> index] -> node
        // node -> [next -> index] -> node


        // dict<Node, index>
        var oldDict = new Dictionary<Node, int>();
        int i = 0;
        Node current = head;
        while (current is not null) {
            oldDict[current] = i;
            i ++;
            current = current.next;
        }

        // nodes
        Node[] newNodes = new Node[oldDict.Keys.Count];
        foreach (var oldNode in oldDict.Keys) {
            int index = oldDict[oldNode];
            Node newNode = new(oldNode.val);
            newNodes[index] = newNode;
        }

        // next, random
        foreach (var oldNode in oldDict.Keys) {
            int index = oldDict[oldNode];
            Node newNode = newNodes[index];

            if (oldNode.random is not null) {
                int randomIndex = oldDict[oldNode.random];
                newNode.random = newNodes[randomIndex];
            }

            if (oldNode.next is not null) {
                int nextIndex = oldDict[oldNode.next];
                newNode.next = newNodes[nextIndex];
            }
        }

        return newNodes.FirstOrDefault();
    }
}
