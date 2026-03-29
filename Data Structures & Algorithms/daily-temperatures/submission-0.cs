public class Solution {
    public int[] DailyTemperatures(int[] ts) {
        // if stack is empty, push
        // if not empty && current t > peek, calc popped ele's distance, finally push current ele

        var distances = new int[ts.Length];

        var stack = new Stack<Element>();
        for (int i = 0; i < ts.Length; i ++) {
            int t = ts[i];
            while (stack.Count > 0 && stack.Peek().Temperature < t) {
                Element popped = stack.Pop();
                int distance = i - popped.Index;    
                distances[popped.Index] = distance;
            }

            stack.Push(new Element(i, t));
        }

        return distances;
    }

    public record Element(int Index, int Temperature);
}
