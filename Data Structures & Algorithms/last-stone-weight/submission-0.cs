public class Solution {
    public int LastStoneWeight(int[] stones) {
        var queue = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));
        
        foreach (var stone in stones) {
            queue.Enqueue(stone, stone);
        }

        while (queue.Count > 1) {
            var s1 = queue.Dequeue();
            var s2 = queue.Dequeue();

            if (s1 == s2) {
                continue;
            } else {
                var smash = Math.Abs(s1 - s2);
                queue.Enqueue(smash, smash);
            }
        }

        if (queue.Count == 1) {
            return queue.Dequeue();
        }

        return 0;
    }
}
