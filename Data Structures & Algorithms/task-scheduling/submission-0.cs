public class Solution {
    public int LeastInterval(char[] tasks, int n) {
        int[] count = new int[26];
        foreach (var task in tasks) {
            count[task - 'A']++;
        }

        var maxHeap = new PriorityQueue<int, int>(
            Comparer<int>.Create((a, b) => b.CompareTo(a))
        );
        for (int i = 0; i < 26; i++) {
            if (count[i] > 0) {
                maxHeap.Enqueue(count[i], count[i]);
            }
        }

        int time = 0;
        Queue<int[]> queue = new Queue<int[]>();
        while (maxHeap.Count > 0 || queue.Count > 0) {
            // available again
            if (queue.Count > 0 && time >= queue.Peek()[1]) {
                int[] temp = queue.Dequeue();
                maxHeap.Enqueue(temp[0], temp[0]);
            }

            // run the max count
            if (maxHeap.Count > 0) {
                int cnt = maxHeap.Dequeue() - 1;
                if (cnt > 0) {
                    // skip n, so next available is at +1
                    queue.Enqueue(new int[] { cnt, time + n + 1 });
                }
            }

            time++;
        }

        return time;
    }
}
