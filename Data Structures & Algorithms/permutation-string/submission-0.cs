public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if (s1.Length > s2.Length) {
            return false;
        }

        // check the window
        // move l to right, move r to right
        int[] set1 = new int[26];
        foreach (var ch in s1) {
            set1[ch - 'a'] ++;
        }

        int m = s1.Length;
        int l = 0;
        int r = 0 + m - 1;
        while (r < s2.Length) {
            int[] set2 = new int[26];
            for (int i = l; i <= r; i ++) {
                set2[s2[i] - 'a'] ++;
            }

            if (AreSame(set1, set2)) {
                return true;
            }

            l ++;
            r ++;
        }

        return false;
    }

    private bool AreSame(int[] set1, int[] set2) {
        if (set1.Length != set2.Length) {
            return false;
        }

        for (var i = 0; i < set1.Length; i ++) {
            if (set1[i] != set2[i]) {
                return false;
            }
        }

        return true;
    }
}
