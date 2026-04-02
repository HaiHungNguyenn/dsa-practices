public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> set = nums.ToHashSet();
        return set.Count() != nums.Count();
    }
}