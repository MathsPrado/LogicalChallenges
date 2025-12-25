using System;
namespace GoodPatis
{
	public class GoodPairsValidation
	{
		public GoodPairsValidation()
		{
		}

        public  static int NumIdenticalPairs(int[] nums)
        {
            int goodPairs = 0;
            int[] frequency = new int[101];

            foreach (int num in nums)
            {
                goodPairs += frequency[num];
                frequency[num]++;
            }

            return goodPairs;
        }
    }
}

