public class Solution {
    public int MaxProfit(int[] prices) {
        int buyPrice = int.MaxValue;
        int maxProfit = 0;

        foreach(int currentPrice in prices){
            if(buyPrice > currentPrice){
                buyPrice = currentPrice;
                continue;
            }
            if(maxProfit < currentPrice - buyPrice)
                maxProfit = currentPrice - buyPrice;
        }

        return maxProfit;
    }
}