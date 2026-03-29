public class LRUCache {
    private int capacity;
    private Dictionary<int, LinkedListNode<(int key, int val)>> map;
    private LinkedList<(int key, int val)> list;

    public LRUCache(int capacity) {
        this.capacity = capacity;
        map = new Dictionary<int, LinkedListNode<(int, int)>>();
        list = new LinkedList<(int, int)>();
    }

    public int Get(int key) {
        if (!map.TryGetValue(key, out var node))
            return -1;

        list.Remove(node);
        list.AddFirst(node);
        return node.Value.val;
    }

    public void Put(int key, int value) {
        if (map.TryGetValue(key, out var node)) {
            list.Remove(node);
        } else if (map.Count == capacity) {
            var last = list.Last;
            list.RemoveLast();
            map.Remove(last.Value.key);
        }

        var newNode = new LinkedListNode<(int, int)>((key, value));
        list.AddFirst(newNode);
        map[key] = newNode;
    }
}
