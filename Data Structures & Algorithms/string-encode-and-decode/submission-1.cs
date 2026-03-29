public class Solution {

    public string Encode(IList<string> strs) {
        // length#s

        var sb = new StringBuilder("");
        foreach (var str in strs) {
            sb.Append($"{str.Length}#{str}");
        }

        return sb.ToString();
    }

    public List<string> Decode(string s) {
        var res = new List<string>();

        var i = 0;
        while (i < s.Length) {
            var j = i;
            while (s[j] != '#') {
                j ++;
            }

            var numStr = s.Substring(i, j-i);
            var length = int.Parse(numStr);

            var str = s.Substring(j + 1, length);
            res.Add(str);

            i = j + length + 1;
        }

        return res;
   }
}
