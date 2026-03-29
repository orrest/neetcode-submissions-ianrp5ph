public class Solution {
    public int Search(int[] nums, int target) {
        // find the splitor
        // find the ele in specific half

        int pivot = FindMin(nums);

        int result = BinarySearch(nums, target, 0, pivot - 1);
        if (result != -1) {
            return result;
        }

        return BinarySearch(nums, target, pivot, nums.Length - 1);

    }

    public int BinarySearch(int[] nums, int target, int left, int right) {
        while (left <= right) {
            int mid = (left + right) / 2;
            if (nums[mid] == target) {
                return mid;
            } else if (nums[mid] < target) {
                left = mid + 1;
            } else {
                right = mid - 1;
            }
        }
        return -1;
    }

    public int FindMin(int[] nums) {
        // compare to left

        int minNum = nums[0];
        int minIndex = 0;
        int left = 0, right = nums.Length-1;
        while (left <= right) {
            // if left ele < right ele, then 
            // the rest of [left, right] is ascending order,
            // so just consider the left ele.
            // if didn't break from this point, 
            // then the mid may ignore [left, mid-1] part eles.
            if (nums[left] < nums[right]) {
                minNum = Math.Min(minNum, nums[left]);
                minIndex = minNum == nums[left] ? left : minIndex;
                break;
            }

            int mid = left + (right - left) / 2;
            minNum = Math.Min(minNum, nums[mid]);
            minIndex = minNum == nums[mid] ? mid : minIndex;

            if (nums[mid] >= nums[left]) {
                left = mid + 1;
            } else {
                right = mid - 1;
            }
        }

        return minIndex;
    }
}
