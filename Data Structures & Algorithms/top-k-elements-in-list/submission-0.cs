public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> Dictionary = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i ++ )
        {
            if (Dictionary.ContainsKey(nums[i]))
            {
                Dictionary[nums[i]] ++;
            } else
            {
                Dictionary[nums[i]] = 1;
            }
        }

        int[] keys = Dictionary.Keys.ToArray();
        Array.Sort(keys);
        Array.Reverse(keys);
        List<int> result = new List<int>();

        for (int i = 0; i < k; i ++)
        {
            result.Add(keys[i]);
        }

        return result.ToArray();
    }
}
