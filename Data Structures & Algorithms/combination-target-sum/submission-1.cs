public class Solution {
    public List<List<int>> CombinationSum(int[] nums, int target) {
        backtrace(0, target, nums, 0, new List<int>());
        return res;
    }

    private List<List<int>> res = new();
    private void backtrace(int total, int target, int[] nums, int i, List<int> cur) {
        if (total == target) {
            res.Add(cur.ToList());
            return;
        } 

        if (total > target || i >= nums.Length) {
            return;
        } 

        // total < target

        cur.Add(nums[i]);
        backtrace(total + nums[i], target, nums, i, cur);
        
        cur.RemoveAt(cur.Count - 1);
        backtrace(total, target, nums, i + 1, cur);
    }
}
