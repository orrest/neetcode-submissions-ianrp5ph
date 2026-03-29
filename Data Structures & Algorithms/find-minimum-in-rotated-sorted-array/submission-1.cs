public class Solution {
    public int FindMin(int[] nums) {
        // compare to left

        int minNum = nums[0];
        int left = 0, right = nums.Length-1;
        while (left <= right) {
            if (nums[left] < nums[right]) {
                minNum = Math.Min(minNum, nums[left]);
                break;
            }

            int mid = left + (right - left) / 2;
            minNum = Math.Min(minNum, nums[mid]);

            if (nums[mid] >= nums[left]) {
                left = mid + 1;
            } else {
                right = mid - 1;
            }
        }

        return minNum;
    }
}
