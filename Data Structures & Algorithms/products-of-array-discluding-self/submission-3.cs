public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int prod = 1;
        int zeroCount = 0;
        int[] res = new int [nums.Length];
        for( int i = 0; i < nums.Length; i ++)
        {
            if (nums[i] == 0)
            {
                zeroCount ++;
            } else
            {
                prod = prod * nums[i];
            }
        }

        if (zeroCount > 1)
        {
            return res;
        }

        for (int i = 0; i < nums.Length; i ++)
        {
            if (zeroCount > 0)
            {
                res[i] = nums[i] == 0 ? prod : 0;
            } else
            {
                res[i] = prod / nums[i];
            }
        }

        return res;
    }
}
