public class Solution {
    public int CharacterReplacement(string s, int k) {

        var count = new Dictionary<char, int>();
        int l = 0, regionMaxFreq = 0, maxLength = 0;

        for (int r = 0; r < s.Length; r ++) {
            if (count.ContainsKey(s[r])) {
                count[s[r]] ++;
            } else {
                count[s[r]] = 1;
            }

            regionMaxFreq = Math.Max(regionMaxFreq, count[s[r]]);

            while ((r - l + 1) - regionMaxFreq > k) {
                count[s[l]] --;
                l++;
            }

            maxLength = Math.Max((r - l + 1), maxLength);
        }

        return maxLength;
    }
}
