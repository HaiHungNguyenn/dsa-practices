public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        if (strs.Length < 2)
            return [[strs[0]]];

        Dictionary<string, List<string>> Dictionary = new Dictionary<string, List<string>>();
        for ( int  i = 0 ; i < strs.Length; i ++)
        {
            char[] chars = strs[i].ToCharArray();
            Array.Sort(chars);
            string sortedStr = new string(chars);
            if (Dictionary.GetValueOrDefault(sortedStr) == null)
            {
                Dictionary[sortedStr] = new List<string>(){ strs[i] };
            } else
            {
                Dictionary[sortedStr].Add(strs[i]);
            }
        }
        
        return Dictionary.Values.ToList<List<string>>();
    }
}
