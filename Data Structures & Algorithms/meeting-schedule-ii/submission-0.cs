/**
 * Definition of Interval:
 * public class Interval {
 *     public int start, end;
 *     public Interval(int start, int end) {
 *         this.start = start;
 *         this.end = end;
 *     }
 * }
 */

public class Solution {
    public int MinMeetingRooms(List<Interval> intervals) {
        // minheap to store parallel intervals
        // sort by start time first

        // the heap size represents the min room count, because
        // if a meeting end, the new one will either use the same
        // room or the room released earlier,
        // if a meeting not end, the latter meeting will have to use 
        // a new room,
        
        intervals.Sort(Comparer<Interval>.Create(
            (a, b) => a.start.CompareTo(b.start)
        ));

        var minHeap = new PriorityQueue<Interval, int>();
        foreach (var interval in intervals) {
            if (minHeap.Count > 0 && minHeap.Peek().end <= interval.start) {
                minHeap.Dequeue();
            }
            minHeap.Enqueue(interval, interval.end);
        }

        return minHeap.Count;
    }
}
