public class Solution {
    public int[][] Merge(int[][] intervals) {
        var result = new List<int[]>();

        // sort
        Array.Sort(intervals, Comparer<int[]>.Create((a,b) => a[0].CompareTo(b[0])));

        // foreach, merge, add
        // two pointers, one at current, one for next and merge,
        // until not overlapping, set first one at new location,
        // and update next
        int current = 0;
        int next = 1;
        int n = intervals.Length;
        while (current < n && next < n) {
            int[] cis = intervals[current];
            int[] nis = intervals[next];
            bool isOverlapping = IsOverlapping(cis, nis);
            if (isOverlapping) {
                cis[0] = Math.Min(cis[0], nis[0]);
                cis[1] = Math.Max(cis[1], nis[1]);
                next ++;
            } else {
                result.Add(cis);
                current = next;
                next = current + 1;
            }
        }

        if (current < n) {
            result.Add(intervals[current]);
        }

        //return
        return result.ToArray();
    }

    private bool IsOverlapping(int[] a, int[] b) {

        return a[1] >= b[0];
    }
}
