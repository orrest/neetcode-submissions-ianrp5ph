public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        // deq, 
        // left, out of index, remove
        // right, bigger than last, remove last, enqueue

        int n = nums.Length;
        var res = new List<int>();
        var q = new LinkedList<int>();
        int l = 0, r = 0;
        while (r < n) {
            // remove smallers
            while (q.Count > 0 && nums[r] > nums[q.Last.Value]) {
                q.RemoveLast();
            }

            // add current, assume it is the biggest
            // (and if not, it will be removed next at iteration)
            q.AddLast(r);

            if (l > q.First.Value) {
                q.RemoveFirst();
            }

            // r == k-1 is the 1st window
            if (r >= k - 1) {
                res.Add(nums[q.First.Value]);
                l++;
            }

            r ++;
        }

        return res.ToArray();
    }
}
