using System;
using System.Collections.Generic;
using System.Text;

namespace algorithms_and_data_structures.day1
{
    public class Rotate
    {
        public void Rotate1(int[] nums, int k)
        {
            //暴力方法，时间复杂度为O(n);依次向右挪移k次
            int lastNum = 0;
            for (int j = 0; j < k; j++)
            {
                lastNum = nums[nums.Length - 1];
                for (int i = nums.Length - 1; i > 0; i--)
                {
                    nums[i] = nums[i - 1];
                }
                nums[0] = lastNum;
            }
        }

        public void Rotate2(int[] nums, int k)
        {
            //三次翻转算法
            k %= nums.Length;
            Array.Reverse(nums, 0, nums.Length - k);
            Array.Reverse(nums, nums.Length - k, k);
            Array.Reverse(nums);
        }
    }
}
