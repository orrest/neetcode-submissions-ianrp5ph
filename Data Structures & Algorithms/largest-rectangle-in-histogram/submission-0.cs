public class Solution {
    private int[][] cache;

    public int LargestRectangleArea(int[] heights) {
        if (heights.Length == 0) {
            return 0;
        }

        int n = heights.Length;
        cache = new int[n][];
        for (int i = 0; i < n; i ++) {
            cache[i] = new int[n];
            for (int j = 0; j < n; j ++) {
                cache[i][j] = -1;
            }
        }

        return f(heights, 0, n - 1);
    }

    // 递归
    // 子问题：两边分别缩小
    // 计算方式：
        // 先计算当前的，然后左右分别缩小一个
        // 返回这三者之中最大的
    private int f(int[] hs, int leftIndex, int rightIndex) {
        if (leftIndex > rightIndex) {
            return 0;
        }

        if (leftIndex == rightIndex) {
            int a = hs[leftIndex] * 1;
            cache[leftIndex][rightIndex] = a;
            return a;
        }

        int width = rightIndex - leftIndex + 1;
        int height = hs[leftIndex];
        for (int i = leftIndex + 1; i <= rightIndex; i ++ ) {
            height = Math.Min(hs[i], height);
        }
        int area = width * height;

        int leftArea = 0;
        if (cache[leftIndex+1][rightIndex] != -1) {
            leftArea = cache[leftIndex+1][rightIndex];
        } else {
            leftArea = f(hs, leftIndex + 1, rightIndex);
        }

        int rightArea = 0;
        if (cache[leftIndex][rightIndex - 1] != -1) {
            rightArea = cache[leftIndex][rightIndex - 1];
        } else {
            rightArea = f(hs, leftIndex, rightIndex - 1);
        }

        int maxArea = Math.Max(Math.Max(leftArea, rightArea), area);

        cache[leftIndex][rightIndex] = maxArea;

        return maxArea;
    }
}
