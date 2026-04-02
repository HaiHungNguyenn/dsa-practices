public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> dictionary = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i ++)
        {
            int different = target - nums[i];
            if (dictionary.ContainsKey(different))
            {
                return [dictionary.GetValueOrDefault(different), i];
            } else
            {
                dictionary[nums[i]] = i;
            }
        }
        return [];
    }
}
