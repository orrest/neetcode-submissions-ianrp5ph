public class Solution {
    public int MaxProfit(int[] prices) {
        
        // if sell at today's price
        var maxProfit = 0;
        // history lowest price
        var minBuy = prices[0];

        foreach (var today in prices) {
            maxProfit = Math.Max(maxProfit, today - minBuy);
            minBuy = Math.Min(minBuy, today);
        }

        return maxProfit;
    }
}
