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

        var arr = Dictionary.Select(dic => new int []{dic.Value, dic.Key}.ToList()).ToList();
        arr.Sort((a,b) => b[0].CompareTo(a[0]));

        List<int> result = new List<int>();

        for (int i = 0; i < k; i ++)
        {
            result.Add(arr[i][1]);
        }

        return result.ToArray();
    }
}
