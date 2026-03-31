public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        // merge
        int[] nums = Merge(nums1, nums2);

        // median eles
        if (nums.Length % 2 == 1) {
            return (double)(nums[nums.Length / 2]);
        } else {
            int mid = nums.Length / 2;
            return (nums[mid] + nums[mid-1]) / 2d;
        }
    }

    private int[] Merge(int[] nums1, int[] nums2) {
        int m = nums1.Length;
        int n = nums2.Length;
        int[] nums = new int[m + n];
        int i = 0, j = 0;
        int a = 0;
        while (i < m && j < n) {
            if (nums1[i] < nums2[j]) {
                nums[a++] = nums1[i ++];
            } else {
                nums[a++] = nums2[j ++];
            }
        }
        
        while (i < m) {
            nums[a++] = nums1[i++];
        }

        while (j < n) {
            nums[a++] = nums2[j++];
        }

        return nums;
    }
}
