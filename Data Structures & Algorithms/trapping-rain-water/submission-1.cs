public class Solution {
    public int Trap(int[] height) {
        // update max height first, so will not be negative
        // start at left, right
        // 

        int l = 0, r = height.Length - 1;
        int res = 0;
        int lm = height[l], rm = height[r];
        while (l < r) {
            if (lm < rm){
                l++;
                lm = Math.Max(lm, height[l]);
                res += lm - height[l];
            } else {
                r--;
                rm = Math.Max(rm, height[r]);
                res += rm - height[r];
            }
        }

        return res;
    }
}
