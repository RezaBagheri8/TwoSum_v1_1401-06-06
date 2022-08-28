using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    public class TwoSumImplement
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int firstIndex = 0;
            int secondIndex = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        firstIndex = i;
                        secondIndex = j;
                        break;
                    }
                }
            }

            int[] result = new int[2];
            result[0] = firstIndex;
            result[1] = secondIndex;
            return result;
        }
    }
}
