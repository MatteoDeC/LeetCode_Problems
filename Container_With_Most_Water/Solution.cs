public class Solution
{
    public int MaxArea(int[] height)
    {
        int maxArea = 0;
        int start = 0;
        int end = height.Length - 1;

        while (start < end)
        {
            int area = (end - start) * Math.Min(height[start], height[end]);
            if (area > maxArea)
                maxArea = area;

            if (height[start] < height[end])
                start++;
            else
                end--;
        }

        return maxArea;
    }
}