public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        // use 26 size array instead of hash table
        // serialize the array to a specified key
        // use the key as the dictionary key

        var dict = new Dictionary<string, List<string>>();

        foreach (var str in strs) {
            int[] arr = new int[26];
            foreach (var ch in str) {
                arr[ch - 'a'] ++;
            }

            string key = string.Join(",", arr);

            if (!dict.ContainsKey(key)) {
                dict[key] = new List<string>();
            }

            dict[key].Add(str);
        }

        return dict.Values.ToList();
    }
}
