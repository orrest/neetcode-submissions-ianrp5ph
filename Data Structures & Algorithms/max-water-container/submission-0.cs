public class Solution {
    public int MaxArea(int[] heights) {
        int i = 0, j = heights.Length - 1;

        int maxArea = 0;
        while (i < j) {
            // current area
            var area = Math.Min(heights[i], heights[j]) * (j - i);
            // update max area
            maxArea = Math.Max(area, maxArea);
            // update index
            if (heights[i] < heights[j]) {
                i ++;
            } else {
                j --;
            }
        }

        return maxArea;
    }
}
