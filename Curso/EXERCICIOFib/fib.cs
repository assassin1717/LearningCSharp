using System.Collections.Generic;

namespace EXERCICIOFib
{
    class fib
    {
        public int Fibona(int n)
        {
            List<int> nums = new List<int>();
            for (int x =0; x<n; x++)
            {
                if (x>1)
                {
                    nums.Add(nums[x-1]+ nums[x - 2]);
                }
                else if(x==1)
                {
                    nums.Add(1);
                }
                else
                {
                    nums.Add(0);
                }
            }
            return nums[n-1];
        }
    }
}
