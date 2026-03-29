public class Solution {
    public int EvalRPN(string[] tokens) {
        // push 
        // when encounter operator, pop nums, calc, push
        // continue

        var stack = new Stack<long>();
        foreach (var token in tokens) {
            bool isNum = long.TryParse(token, out long num);

            if (isNum) {
                stack.Push(num);
            } else {
                long op2 = stack.Pop();
                long op1 = stack.Pop();
                long res = Calc(token, op1, op2);
                stack.Push(res);
            }
        }

        return (int)stack.Pop();
    }

    private long Calc(string @operator, long op1, long op2) {
        return @operator switch{
            "+" => op1 + op2,
            "-" => op1 - op2,
            "*" => op1 * op2,
            "/" => op1 / op2,
        };
    }
}
