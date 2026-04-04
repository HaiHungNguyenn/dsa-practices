public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] result = new int[nums.Length];

        for (int i = 0; i < nums.Length; i ++)
        {
            var value = 1;
            for (int j = 0; j < nums.Length; j ++)
            {
                if (i == j)
                    continue;

                value = value * nums[j];
            }
            result[i] = value;
        }

        return result;
    }
}
