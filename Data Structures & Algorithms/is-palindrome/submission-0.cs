public class Solution {
    public bool IsPalindrome(string s) {
        // [1, 1000]

        s = s.ToLower();

        var i = 0;
        var j = s.Length - 1;
        while (i < j) {
            while (i < j && !char.IsLetterOrDigit(s[i])){
                i ++;
            }

            while (i < j && !char.IsLetterOrDigit(s[j])){
                j --;
            }

            if (i >= j){
                break;
            }

            if (s[i] != s[j]){
                return false;
            }

            i ++;
            j --;
        }

        return true;
    }
}
