public class Solution {
    public List<List<int>> CombinationSum(int[] nums, int target) {
        backtrace(0, target, nums, new List<int>(), 0);
        return res;
    }

    private List<List<int>> res = new();
    private void backtrace(int total, int target, int[] nums, List<int> cur, int i) {
        if (total == target) {
            res.Add(cur.ToList());
            return;
        }

        if (total > target || i >= nums.Length) {
            return;
        }

        // total < target
        cur.Add(nums[i]);
        backtrace(total + nums[i], target, nums, cur, i);

        cur.RemoveAt(cur.Count - 1);
        backtrace(total, target, nums, cur, i + 1);
    }
}
