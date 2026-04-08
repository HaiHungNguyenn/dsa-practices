public class Solution {
    public int PivotIndex(int[] nums) {
        int sum = 0;
        for( int i = 0; i < nums.Length; i ++)
        {
            sum += nums[i];
        }

        int totalS = 0;
        int pivot = -1;
        for (int i = 0; i < nums.Length - 1; i ++)
        {
            if (totalS == sum - totalS - nums[i])
            {
                pivot = i;
            } else
            {
                totalS += nums[i];
            }
        }
        return pivot;
    }
}