public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var set = new HashSet<char>();

        int l = 0;
        int res = 0;
        for (int r = 0; r < s.Length; r ++) {
            // if alread have s[r] char, move left
            while (set.Contains(s[r])) {
                set.Remove(s[l]);
                l ++;
            }

            // add s[r] char
            set.Add(s[r]);

            // calc new max
            res = Math.Max(res, r-l+1);
        }

        return res;
    }
}
