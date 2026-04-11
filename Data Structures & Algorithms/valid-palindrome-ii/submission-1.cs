public class Solution {
    public bool ValidPalindrome(string s) {
        int i = 0;
        int j = s.Length - 1;

        while( i <= j)
        {

            if (s[i] == s[j])
            {
                i ++;
                j --;
                continue;
            }

            return IsPalindrome(s, i + 1, j) || IsPalindrome(s, i , j - 1);
        }
       return true;
    }

    public bool IsPalindrome(string s, int from, int to)
    {
        int i = from;
        int j = to;
        while (i <= j)
        {
            if(s[i] != s[j])
            {
                return false;
            }

            i ++;
            j --;
        }

        return true;
    }
}