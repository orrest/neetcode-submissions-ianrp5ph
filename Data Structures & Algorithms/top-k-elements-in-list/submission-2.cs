public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        // use a dictionary to count the frequency
        // use a min priority queue to count the top k
        // if queue count < k, enqueue,
        // else 
            // compare the queue top and the new element

        // count the frequent
        var dict = new Dictionary<int, int>();
        foreach (var num in nums) {
            if (dict.ContainsKey(num)) {
                dict[num] ++;
            } else {
                dict[num] = 1;
            }
        }

        // count the max freq
        // num, frequent
        var queue = new PriorityQueue<int, int>();
        foreach (var key in dict.Keys) {
            queue.Enqueue(key, dict[key]);
            if (queue.Count > k) {
                queue.Dequeue();
            }
        }

        var lst = new List<int>();
        while (queue.Count > 0) {
            var ele = queue.Dequeue();
            lst.Add(ele);
        }

        return lst.ToArray();
    }
}
