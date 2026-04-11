public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        int canPlaceCount = 0;
        for (int i = 1; i < flowerbed.Length - 1; i ++)
        {
            if (flowerbed[i] == 0 && flowerbed[i - 1] == 0 && flowerbed[i + 1] == 0)
            {
                canPlaceCount ++;
            }
        }

        return canPlaceCount == n || canPlaceCount > n;
    }
}