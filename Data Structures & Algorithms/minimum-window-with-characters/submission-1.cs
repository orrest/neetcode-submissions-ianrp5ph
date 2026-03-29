public class Solution {
    public string MinWindow(string s, string t) {
        
        if (s.Length < t.Length) {
            return string.Empty;
        }

        // 统计目标个数（频次相同，字符相同）
        // 移动右侧边界
        // 当计入新字符后得到一样的频次，count ++
        // 当 count == target，不断左移，记录移动后仍符合的边界
        // 返回最终的边界

        var freqT = new Dictionary<char, int>();
        foreach (var ch in t) {
            if (freqT.ContainsKey(ch)) {
                freqT[ch] ++;
            } else {
                freqT[ch] = 1;
            }
        }

        int target = freqT.Keys.Count;
        int count = 0;

        int minLength = int.MaxValue;
        int resLeft = -1;

        var freqS = new Dictionary<char, int>();
        int l = 0;
        for (int r = 0; r < s.Length; r ++) {
            if (freqS.ContainsKey(s[r])) {
                freqS[s[r]] ++;
            } else {
                freqS[s[r]] = 1;
            }

            if (freqT.ContainsKey(s[r]) && freqT[s[r]] == freqS[s[r]]) {
                count ++;
            }

            while (count == target) {
                int currentLength = r - l + 1;
                char currentChar = s[l];
                if (currentLength < minLength) {
                    minLength = currentLength;
                    resLeft = l;
                }

                freqS[currentChar] --;

                // freqS[currentChar] can > freqT[currentChar]
                // and that's correct, count no need --
                if (freqT.ContainsKey(currentChar) 
                    && freqS[currentChar] < freqT[currentChar]) {
                    count --;
                }

                l ++;
            }
        }

        return minLength == int.MaxValue ? string.Empty : s.Substring(resLeft, minLength);
    }
}
