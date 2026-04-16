public class Solution {
    public bool IsValid(string s) {
        int left = 0;
        int right = s.Length - 1;
        while (left <= right)
        {
            if (IsMatchingPair(s[left],s[right]))
            {
                left ++;
                right --;
            } else {
                return false;
            }
        }
        return true;
    }

    private bool IsMatchingPair(char left, char right)
    {
        return (left == '(' && right == ')') ||
               (left == '{' && right == '}') ||
               (left == '[' && right == ']');
    }
}
