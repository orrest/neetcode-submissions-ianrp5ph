public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        // min k == 1, h == piles.Sum()
        // max k == piles.Max, h == piles.Length
        // binary search for k where h_count == h (or h_count most close to h)
        // find min k means use more hours close to h

        int minSpeed = 1, maxSpeed = piles.Max();
        int targetSpeed = maxSpeed;
        while (minSpeed <= maxSpeed) {
            int midSpeed = minSpeed + (maxSpeed - minSpeed) / 2;
            int hours = CountHours(piles, midSpeed);
            if (hours <= h) {
                targetSpeed = Math.Min(midSpeed, targetSpeed);
            }

            if (hours > h) {
                minSpeed = midSpeed + 1;
            } else {
                maxSpeed = midSpeed - 1;
            }
        }

        return targetSpeed;
    }

    private int CountHours(int[] piles, int speed) {
        return piles.Select(p => (p + speed - 1) / speed).Sum();
    }
}
