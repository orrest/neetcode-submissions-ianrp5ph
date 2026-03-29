public class Solution {
    public int LongestConsecutive(int[] nums) {
        // set nums
        var set = new HashSet<int>(nums);

        // for every num, if num is start, find longest
        var longest = 0;
        foreach (var num in nums) {
            if (!set.Contains(num-1)) {
                var currentLongest = 0;
                var start = num;
                while (set.Contains(start)) {
                    start ++;
                    currentLongest ++;
                }
                longest = Math.Max(longest, currentLongest);
            }
            else {
                continue;
            }
        }

        return longest;
    }
}
