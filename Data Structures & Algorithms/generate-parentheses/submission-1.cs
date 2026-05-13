public class Solution {  
    public List<string> GenerateParenthesis(int n) {
        Backtrace(0, 0, n, "");
        return res;
    }

    private List<string> res = new();
    private void Backtrace(int left, int right, int n, string cur) {
        if (left == right && right == n) {
            res.Add(cur);
            return;
        }

        if (left < n) {
            Backtrace(left+1, right, n, cur + "(");
        }
        
        if (left > right) {
            Backtrace(left, right+1, n, cur +")");
        }
    }
}
