public class MinStack {
    private Stack<Frame> _stack = new();

    public MinStack() {
        
    }
    
    public void Push(int val) {
        int previousMin = val;
        if (_stack.Count > 0) {
            previousMin = _stack.Peek()._min;
        }
        var frame = new Frame(val, Math.Min(val, previousMin));
        _stack.Push(frame);
    }
    
    public void Pop() {
        _stack.Pop();
    }
    
    public int Top() {
        var frame = _stack.Peek();

        return frame._value;
    }
    
    public int GetMin() {
        return _stack.Peek()._min;
    }

    public class Frame {
        public int _value;
        public int _min;

        public Frame(int value, int min) {
            _value = value;
            _min = min;
        }
    }
}
