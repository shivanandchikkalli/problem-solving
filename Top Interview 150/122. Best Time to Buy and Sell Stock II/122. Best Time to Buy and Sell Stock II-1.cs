public class Solution {
    public int MaxProfit(int[] prices) {
        int profit = 0;
        bool bought = false;
        bool sold = false;
        int buyValue = 0;
        int sellValue = 0;

        for(int i = 1 ; i < prices.Length ; i++)
        {
            if(prices[i] > prices[i - 1] && !bought){
                //buy
                bought = true;
                sold = false;
                buyValue = prices[i - 1];
                Console.WriteLine($"{i} buy value = {buyValue}");
            }
            if(bought && prices[i] < prices[i - 1] ) {
                //sell
                sold = true;
                bought = false;
                sellValue = prices[i - 1];
                profit += sellValue - buyValue;
                Console.WriteLine($"{i} sell value = {sellValue}");
            }
        }

        if(bought){
            Console.WriteLine($"{prices.Length - 1} sell value = {(sold ? sellValue : prices[prices.Length - 1])}");
            profit += (sold ? sellValue : prices[prices.Length - 1]) - buyValue;
        }
        
        return profit;
    }
}