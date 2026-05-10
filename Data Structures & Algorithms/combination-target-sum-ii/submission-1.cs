public class Solution {
    public List<List<int>> CombinationSum2(int[] candidates, int target) {
        Array.Sort(candidates);
        backtrace(0, target, candidates, 0, new List<int>());
        return res;
    }

    private List<List<int>> res = new();
    // list all unique combinations  the chosen numbers sum == target.
    private void backtrace(int total, int target, int[] nums, int i, List<int> cur) {
        if (total == target) {
            res.Add(cur.ToList());
            return;
        }

        if (total > target || i >= nums.Length) {
            return;
        }

        // choose current, rest of the posibility
        cur.Add(nums[i]);
        backtrace(total + nums[i], target, nums, i + 1, cur);

        // not choose current, rest of the posibility
        cur.RemoveAt(cur.Count - 1);
        // skip duplicate element
        while (i + 1 < nums.Length && nums[i] == nums[i + 1]) {
            i++;
        }
        backtrace(total, target, nums, i + 1, cur);
    }
}
