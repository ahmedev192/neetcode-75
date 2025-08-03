//Container With Most Water
public class Solution
{
    public int MaxArea(int[] height)
    {
        int maxArea = 0;
        int left = 0, right = height.Length - 1;

        while (left < right)
        {
            int minHeight = Math.Min(height[left], height[right]);
            int width = right - left;
            int area = minHeight * width;
            maxArea = Math.Max(maxArea, area);

            // Move the pointer with the smaller height
            if (height[left] < height[right])
                left++;
            else
                right--;
        }

        return maxArea;
    }
}
