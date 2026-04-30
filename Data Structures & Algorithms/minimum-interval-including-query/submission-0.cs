public class Solution
{
    public int[] MinInterval(int[][] intervals, int[] queries)
    {
        // <key, region> O(n), region compare when input
        // find, O(1)
        // space O(n)

        var lens = new Dictionary<int, int>();

        foreach (int[] interval in intervals)
        {
            int len = interval[1] - interval[0] + 1;
            for (int i = interval[0]; i <= interval[1]; i++ ) {
                if (!lens.ContainsKey(i))
                {
                    lens[i] = len;
                }
                else if (lens[i] > len)
                {
                    lens[i] = len;
                }
            }
        }

        int[] result = queries.Select(q => lens.ContainsKey(q) ? lens[q] : -1).ToArray();

        return result;
    }
}
