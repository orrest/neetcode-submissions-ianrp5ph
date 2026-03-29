public class Solution {

    public string Encode(IList<string> strs) {
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
            int length = int.Parse(s.Substring(i, j-i));

            // skip #
            i = j + 1;
            j = i + length;
            res.Add(s.Substring(i, length));
            i = j;
        }

        return res;
   }
}
