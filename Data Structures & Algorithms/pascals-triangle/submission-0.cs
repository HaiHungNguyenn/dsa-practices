public class Solution {
    public List<List<int>> Generate(int numRows) {
        List<List<int>> res = new List<List<int>>();

    res.Add(new List<int> { 1 });

    for (int i = 1; i < numRows; i++)
    {
        List<int> prev = res[i - 1];

        int[] prevRow = new int[prev.Count + 2];

        for (int j = 0; j < prev.Count; j++)
        {
            prevRow[j + 1] = prev[j];
        }

        List<int> newRow = new List<int>();

        for (int k = 0; k < prev.Count + 1; k++)
        {
            newRow.Add(prevRow[k] + prevRow[k + 1]);
        }

        res.Add(newRow);
    }

    return res;
    }
}