using System;
using System.Collections.Generic;

namespace cspj
{
    public class Solution
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            var maxlength = nums1.Length + nums2.Length;
            int[] newArray = new int[maxlength];

            int nums1ArrayIndex = 0;
            int nums2ArrayIndex = 0;

            for (int i = 0; i < newArray.Length; i++)
            {
                if (nums1ArrayIndex < nums1.Length)
                {
                    if (nums1[nums1ArrayIndex] <= nums2[nums2ArrayIndex])
                    {
                        newArray[i] = nums1[nums1ArrayIndex];
                        nums1ArrayIndex++;
                    }
                }
            }

            return 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
        }
    }
}
