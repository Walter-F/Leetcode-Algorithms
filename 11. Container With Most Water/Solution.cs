public class Solution {
    public int MaxArea(int[] height) {
        int maxArea = 0;

        int j = height.Length - 1;
        int i = 0;

        // Цикл до тех пор, пока указатели не встретятся вместе
        while (i < j) {

            int l = j - i;
            int h = 0;

            // Выбор минимальной высота
            if (height[j] > height[i]) {
                h = height[i];
                i++;
            } else {
                h = height[j];
                j--;
            }
            
            int area = l * h;
            maxArea = Math.Max(maxArea, area);
        }
        return maxArea;
    }
}