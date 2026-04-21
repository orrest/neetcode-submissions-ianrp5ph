public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        var queue = new PriorityQueue<int[], double>(Comparer<double>.Create((a, b) => b.CompareTo(a)));

        for (int x = 0; x < points.Length; x ++) {
            int px = points[x][0];
            int py = points[x][1];

            double distance = Distance(px, py);
            if (queue.Count < k) {
                queue.Enqueue(points[x], distance);
            } else {
                int[] heapMin = queue.Peek();
                double heapMinDistance = Distance(heapMin[0], heapMin[1]);
                if (heapMinDistance > distance) {
                    queue.Dequeue();
                    queue.Enqueue(new int[] { px, py }, distance);
                }
            }
        }

        int[][] result = new int[k][];
        for (int i = 0; i < k; i++) {
            result[i] = queue.Dequeue();
        }

        return result;
    }

    private double Distance(int x, int y) {
        return Math.Sqrt(x*x + y*y);
    }
}
