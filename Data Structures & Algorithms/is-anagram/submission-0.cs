public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
            return false;

        char[] chars1 = s.ToCharArray();
        char[] chars2 = t.ToCharArray();

        Array.Sort(chars1);
        Array.Sort(chars2);

        return new string(chars1) == new string(chars2);
    }
}
