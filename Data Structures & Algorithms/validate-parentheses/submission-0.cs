public class Solution {
    public bool IsValid(string s) {
        // 1. left bracket, push
        // 2. if peek is corresponding right bracket, pop
        
        // left > right     stack is not 0, s is end
        // left == right    stack is 0, s is end
        // left < right     stack is 0, s is not end

        var stack = new Stack<char>();
        foreach (var ch in s) {
            if (ch == '(' || ch == '[' || ch == '{') {
                stack.Push(ch);
            } else if (stack.Count > 0 && ((ch == ')' && stack.Peek() == '(')
                || (ch == ']' && stack.Peek() == '[')
                || (ch == '}' && stack.Peek() == '{'))) {
                stack.Pop();
            } else {
                return false;
            }
        }

        return stack.Count == 0;
    }
}
