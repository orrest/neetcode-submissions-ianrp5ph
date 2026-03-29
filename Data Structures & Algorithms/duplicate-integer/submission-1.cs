public class Solution {
    public bool hasDuplicate(int[] nums) {
        if (nums == null || nums.Length == 0){
            return false;
        }

        var set = new HashSet<int>();

        for (var i = 0; i < nums.Length; i ++){
            if (!set.Add(nums[i])){
                return true;
            }
        }

        return false;
    }
}
