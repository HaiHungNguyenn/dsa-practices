public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        int canPlaceCount = 0;
        int[] newBed = [0 , ..flowerbed, 0];
        for (int i = 1; i < newBed.Length - 1; i ++)
        {
            if (newBed[i] == 0 && newBed[i - 1] == 0 && newBed[i + 1] == 0)
            {
                newBed[i] = 1;
                canPlaceCount ++;
            }
        }

        return canPlaceCount == n || canPlaceCount > n;
    }
}