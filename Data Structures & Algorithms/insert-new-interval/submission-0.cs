public class Solution {
    public int[][] Insert(int[][] intervals, int[] newInterval) {
        List<int[]> result = new();
        int i = 0;
        
        // Step 1: Add all intervals that end before newInterval starts
        // 添加所有在新区间之前且不重叠的区间
        while (i < intervals.Length && intervals[i][1] < newInterval[0]) {
            result.Add(intervals[i++]);
        }
        
        // Step 2: Merge all overlapping intervals
        // 合并所有与新区间重叠的区间
        while (i < intervals.Length && intervals[i][0] <= newInterval[1]) {
            // 扩展新区间的范围
            newInterval[0] = Math.Min(newInterval[0], intervals[i][0]);
            newInterval[1] = Math.Max(newInterval[1], intervals[i][1]);
            i++;
        }
        result.Add(newInterval);
        
        // Step 3: Add all remaining intervals
        // 添加所有在新区间之后的区间
        while (i < intervals.Length) {
            result.Add(intervals[i++]);
        }
        
        return result.ToArray();
    }
}