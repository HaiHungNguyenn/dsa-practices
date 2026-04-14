public class Solution {
    public bool IsHappy(int n) {
        HashSet<int> set = new HashSet<int>();
        return IsHappy(n ,set);
    }

    private bool IsHappy(int n, HashSet<int> set)
    {
        if (n == 1) 
            return true;

        int nextSum = sumSquareDigit(n);

        if (set.Contains(nextSum))
            return false;

        set.Add(nextSum);

        return IsHappy(nextSum, set);
    }

    private int sumSquareDigit(int n)
    {
        if (n == 0)
            return 0;
        int d = n % 10;
        return d*d + sumSquareDigit(n / 10);
    }
}
