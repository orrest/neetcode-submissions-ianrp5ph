public class Solution {
    public int EraseOverlapIntervals(int[][] intervals) {
        // sort
        // remove bigger prev end interval

        Array.Sort(intervals, Comparer<int[]>.Create((a,b) => {
            return a[0].CompareTo(b[0]);
        }));

        int res = 0;
        int i = 1;
        int prevEnd = intervals[i-1][1];
        while (i < intervals.Length) {
            int start = intervals[i][0];
            int end = intervals[i][1];
            if (start >= prevEnd) {
                prevEnd = end;
            } else {
                res ++;
                prevEnd = Math.Min(end, prevEnd);
            }

            i++;
        }

        return res;
    }
}
