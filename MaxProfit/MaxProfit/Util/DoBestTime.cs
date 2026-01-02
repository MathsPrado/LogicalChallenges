using System;
namespace MaxProfit.Util
{
	public class DoBestTime
	{
		public DoBestTime()
		{
		}
		#region MyRegion
		
		public int GetMaxProfit(int[] prices)
		{
            //so validando se nao e null ou se e com um valor só
            if (prices == null || prices.Length < 2) return 0;

            int minPrice = int.MaxValue;
            int maxProfit = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < minPrice)
                {
                    minPrice = prices[i];
                }
                // Se o preço atual menos o menor preço for maior que o lucro recorde, atualiza.
                else if (prices[i] - minPrice > maxProfit)
                {
                    maxProfit = prices[i] - minPrice;
                }
            }

            return maxProfit;

        }
		#endregion
	}
}
