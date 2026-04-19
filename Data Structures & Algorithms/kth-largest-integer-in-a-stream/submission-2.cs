public class KthLargest {

    int K;
    private PriorityQueue<int, int> heap;
    public KthLargest(int k, int[] nums) {
        K = k;
        heap = new();
        foreach (var num in nums) {
            if (heap.Count < k) {
                heap.Enqueue(num, num);
            } else if (num >= heap.Peek()) {
                heap.Dequeue();
                heap.Enqueue(num, num);
            }
        }
    }
    
    public int Add(int val) {
        heap.Enqueue(val, val);
        if (heap.Count > K) {
            heap.Dequeue();
        }

        return heap.Peek();
    }
}
