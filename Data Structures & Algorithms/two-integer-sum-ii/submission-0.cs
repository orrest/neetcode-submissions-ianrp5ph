public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        // two pointers
        // if sum > target, j --
        // if sum < target, i ++
        // if sum == target, return

        int i = 0, j = nums.Length-1;
        while (i < j) {
            var sum = nums[i] + nums[j];
            if (sum > target) {
                j --;
            } else if (sum < target) {
                i ++;
            } else {
                return new int[2] { i+1, j+1 };
            }
        }

        return new int[2];
    }
}
