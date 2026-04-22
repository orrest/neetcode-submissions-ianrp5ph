public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        var queue = new PriorityQueue<int, int>();

        foreach (var num in nums) {
            if (queue.Count < k) {
                queue.Enqueue(num, num);
            } else if (queue.Peek() < num) {
                queue.Dequeue();
                queue.Enqueue(num, num);
            }
        }

        return queue.Peek();
    }
}
