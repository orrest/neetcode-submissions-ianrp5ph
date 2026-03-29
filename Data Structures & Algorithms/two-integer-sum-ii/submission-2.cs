public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        var l = 0;
        var r = nums.Length - 1;
        while (l < r) {
            var sum = nums[l] + nums[r];
            if (sum > target) {
                r --;
            } else if (sum < target) {
                l ++;
            } else {
                return new int[] { l+1, r+1 };
            }
        }

        return new int[2];
    }
}
