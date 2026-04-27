public class MedianFinder {

    private PriorityQueue<int, int> small; // Max heap for the smaller half
    private PriorityQueue<int, int> large; // Min heap for the larger half

    public MedianFinder() {
        small = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));
        large = new PriorityQueue<int, int>();
    }

    public void AddNum(int num) {
        if (large.Count != 0 && num > large.Peek()) {
            large.Enqueue(num, num);
        } else {
            small.Enqueue(num, num);
        }

        // always make min half have one more or even
        if (small.Count == large.Count + 2) {
            int val = small.Dequeue();
            large.Enqueue(val, val);
        } else if (large.Count == small.Count + 1) {
            int val = large.Dequeue();
            small.Enqueue(val, val);
        }
    }

    public double FindMedian() {
        if (small.Count > large.Count) {
            return small.Peek();
        }

        return (small.Peek() + large.Peek()) / 2.0;
    }
}