public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        HashSet<int> set = new HashSet<int>(numbers);
        for (int i = 0; i < numbers.Length; i ++)
        {
            int difference = target - numbers[i];
            if (set.Contains(difference) && difference != numbers[i])
                return numbers[i] > difference ? [difference, numbers[i]] : [numbers[i], difference];
        }

        return [];
    }
}
