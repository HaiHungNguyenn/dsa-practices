public class Solution {
    public int PivotIndex(int[] nums) {
        int sum = 0;
        for( int i = 0; i < nums.Length; i ++)
        {
            sum += nums[i];
        }

        int totalS = 0;
        for (int i = 0; i < nums.Length; i ++)
        {
            if (totalS == sum - totalS - nums[i])
            {
                return i;
            } else
            {
                totalS += nums[i];
            }
        }
        return -1;
    }
}