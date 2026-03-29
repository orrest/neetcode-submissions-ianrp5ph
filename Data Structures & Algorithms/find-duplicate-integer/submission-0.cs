public class Solution {
    public int FindDuplicate(int[] nums) {
        // count bits

        int n = nums.Length;
        int res = 0;

        for (int b = 0; b < 32; b ++) {
            int currentBitCount = 0, shouldBitCount = 0;
            int mask = 1 << b;
            foreach (var num in nums) {
                if ((num & mask) != 0) {
                    currentBitCount ++;
                }
            }

            for (int num = 1; num < n; num++) {
                if ((num & mask) != 0) {
                    shouldBitCount ++;
                }
            }

            // n + 1 integers, every num appear once,
            // and one num appear twice, 
            // so currentBitCount will only more than
            // shouldBitCount.
            if (currentBitCount > shouldBitCount) {
                res |= mask;
            }
        }

        return res;
    }
}
