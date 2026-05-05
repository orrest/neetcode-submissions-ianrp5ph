public class Solution {
    public int[][] Insert(int[][] intervals, int[] newInterval) {
        
        List<int[]> res = new();
        int i = 0;
        int n = intervals.Length;

        // intervals before newInterval
        while (i < n && intervals[i][1] < newInterval[0]) {
            res.Add(intervals[i]);
            i ++;
        }

        // intervals merge with newInterval
        while (i < n && intervals[i][0] <= newInterval[1]) {
            newInterval[0] = Math.Min(newInterval[0], intervals[i][0]);
            newInterval[1] = Math.Max(newInterval[1], intervals[i][1]);
            i ++;
        }
        res.Add(newInterval);

        // intervals after newInterval
        while (i < n) {
            res.Add(intervals[i]);
            i ++;
        }

        return res.ToArray();
    }
}
