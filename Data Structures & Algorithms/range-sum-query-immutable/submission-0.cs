public class NumArray {
    public int[] nums;
    public NumArray(int[] nums) {
        this.nums = nums;
    }
    
    public int SumRange(int left, int right) {
        int sum = 0;
        if(left == right)
            return this.nums[left];

        for (int i = left; i <= right; i ++)
        {
            sum = sum + this.nums[i];
        }

        return sum;
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(left,right);
 */