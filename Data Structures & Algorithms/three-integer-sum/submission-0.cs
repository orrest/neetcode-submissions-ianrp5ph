public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        // sort to use tow-pointers method
        // fix one num, then calc the sum
        // target is 0

        var res = new List<List<int>>();

        Array.Sort(nums);

        for (var i = 0; i < nums.Length; i++) {
            if (nums[i] > 0) break;
            // can't have duplicates, left different, right could be same
            if (i > 0 && nums[i] == nums[i-1]) continue;

            var l = i + 1;
            var r = nums.Length - 1;
            while (l < r) {
                var target = nums[i] + nums[l] + nums[r];
                if (target < 0) {
                    l ++;
                } else if (target > 0) {
                    r --;
                } else {
                    res.Add(new List<int>() { nums[i], nums[l], nums[r] });
                    l ++;
                    r --;
                    // the i is fixed, and it skip duplicates
                    // the l, r is the same
                    while (l < r && nums[l] == nums[l-1]) {
                        l ++;
                    }
                }
            }
        }

        return res;
    }
}
