public class Solution {
    public List<int> FindDisappearedNumbers(int[] nums) {
        int size = nums.Length;
        List<int> res = new List<int>();

        HashSet<int> hash = new HashSet<int>(nums);

        for (int i = 1; i <= size; i ++)
        {
            if (!hash.Contains(i))
            {
                res.Add(i);
            }
        }

        return res;
    }
}