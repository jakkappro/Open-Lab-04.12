using System;
using System.Security.Authentication;

namespace Open_Lab_04._12
{
    public class Numbers
    {
        public int MissingNum(int[] nums)
        {
            Array.Sort(nums);
            if(nums[0] != 1)
            {
                return 1;
            }

            for(int i = 0; i < nums.Length; i++)
            {
                if(nums[i] % (i + 1) != 0)
                {
                    return (i + 1);
                }
            }
            
            return 10;
        }
    }
}
