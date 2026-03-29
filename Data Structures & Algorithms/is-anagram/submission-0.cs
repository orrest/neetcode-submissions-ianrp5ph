public class Solution {
    public bool IsAnagram(string s, string t) {
        int[] table = new int[26];

        foreach (var sc in s) {
            table['z' - sc] ++;
        }

        foreach (var tc in t) {
            table['z' - tc] --;
        }

        foreach (var i in table) {
            if (i != 0) {
                return false;
            }
        }

        return true;
    }
}
