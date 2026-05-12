public class Solution {
    public List<List<int>> Permute(int[] nums) {
        // find  Permuatation of nums
        // reduce 1 element each time
        if (nums.Length == 0) {
            return new List<List<int>>{new List<int>()};
        }

        List<List<int>> rest = Permute(nums[1..]);
        List<List<int>> res = new();
        foreach (List<int> r in rest) {
            for (int i = 0; i <= r.Count; i++) {
                List<int> copy = new List<int>(r);
                copy.Insert(i, nums[0]);
                res.Add(copy);
            }
        }

        return res;
    }
}
