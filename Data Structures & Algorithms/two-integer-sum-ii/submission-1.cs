public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        Array.Sort(numbers);
        for (int i = 0; i < numbers.Length - 1; i ++)
        {
            if (numbers[i] + numbers[i + 1] == target)
                return [numbers[i], numbers[i + 1]];
        }
        return [];
    }
}
