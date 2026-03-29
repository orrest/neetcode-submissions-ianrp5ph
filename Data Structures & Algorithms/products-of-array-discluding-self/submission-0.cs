public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        
        var pref = new int[nums.Length];
        var suff = new int[nums.Length];
        var res = new int[nums.Length];

        pref[0] = 1;
        for (var i = 1; i < nums.Length; i ++) {
            pref[i] = pref[i-1] * nums[i-1];
        }

        suff[suff.Length - 1] = 1;
        for (var i = suff.Length-2; i >= 0; i --) {
            suff[i] = suff[i+1] * nums[i+1];
        }

        for (var i = 0; i < nums.Length; i ++) {
            res[i] = pref[i] * suff[i];
        }

        return res;
    }
}
