public class Solution {
    public int MaxProfit(int[] prices) {
        
        var maxProfit = 0;
        var minBuy = prices[0];

        foreach (var today in prices) {
            maxProfit = Math.Max(maxProfit, today - minBuy);
            minBuy = Math.Min(minBuy, today);
        }

        return maxProfit;
    }
}
