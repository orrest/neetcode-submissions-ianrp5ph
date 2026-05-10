public class Solution {
    public List<List<int>> SubsetsWithDup(int[] nums) {
        Array.Sort(nums);
        backtrace(nums, 0, new List<int>());
        return res;
    }

    private List<List<int>> res = new();
    private void backtrace(int[] nums, int i, List<int> cur) {
        if (i >= nums.Length) {
            res.Add(cur.ToList());
            return;
        }

        cur.Add(nums[i]);
        backtrace(nums, i+1, cur);
        cur.RemoveAt(cur.Count - 1);

        int j = i + 1;
        while (j < nums.Length && nums[i] == nums[j]) {
            j ++;
        }
        backtrace(nums, j, cur);
    }
}
