public class Solution {
    public bool IsPalindrome(string s) {
        s = s.ToLower();

        int i = 0, j = s.Length - 1;

        while (i < j) {
            while (j > i && !IsLetterOrNumeric(s[i])) {
                i ++;
            }

            while (j > i && !IsLetterOrNumeric(s[j])) {
                j --;
            }

            if (s[i] != s[j]) {
                return false;
            }

            i ++;
            j --;
        }

        return true;
    }

    public bool IsLetterOrNumeric(char c) {
        return (c >= '0' && c <= '9') || char.IsLetter(c);
    }
}
