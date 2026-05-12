public class Solution {
    // because any combinations of `(` and `)` can be represented by appending,
    // so it won't be wrong to just append.
    public void Backtrack(int openN, int closedN, int n, StringBuilder stack) {
        if (openN == closedN && openN == n) {
            res.Add(stack.ToString());
            return;
        }

        if (openN < n) {
            stack.Append('(');
            Backtrack(openN + 1, closedN, n, stack);
            stack.Length --;
        }

        if (closedN < openN) {
            stack.Append(')');
            Backtrack(openN, closedN + 1, n, stack);
            stack.Length --;
        }
    }

    private List<string> res = new List<string>();
    public List<string> GenerateParenthesis(int n) {
        StringBuilder stack = new();
        Backtrack(0, 0, n, stack);
        return res;
    }
}