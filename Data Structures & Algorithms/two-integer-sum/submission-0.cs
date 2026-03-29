public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var table = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i ++) {
            table[nums[i]] = i;
        }

        for (var i = 0; i < nums.Length; i ++) {
            var rest = target - nums[i];
            if (table.TryGetValue(rest, out var j) && i != j) {
                return new int[] { i, j };
            }
        }

        return new int[0];
    }
}
