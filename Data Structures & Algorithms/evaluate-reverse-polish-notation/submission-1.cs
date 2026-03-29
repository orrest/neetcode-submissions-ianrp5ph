public class Solution {
    public int EvalRPN(string[] tokens) {
        // push 
        // when encounter operator, pop nums, calc, push
        // continue

        var stack = new Stack<long>();
        foreach (var token in tokens) {
            if (token == "+") {
                long op1 = stack.Pop();
                long op2 = stack.Pop();
                long res = op2 + op1;
                stack.Push(res);
            } else if (token == "-") {
                long op1 = stack.Pop();
                long op2 = stack.Pop();
                long res = op2 - op1;
                stack.Push(res);
            } else if (token == "*") {
                long op1 = stack.Pop();
                long op2 = stack.Pop();
                long res = op2 * op1;
                stack.Push(res);
            } else if (token == "/") {
                long op1 = stack.Pop();
                long op2 = stack.Pop();
                long res = op2 / op1;
                stack.Push(res);
            } else {
                long num = long.Parse(token);
                stack.Push(num);
            }
        }

        return (int)stack.Pop();
    }
}
