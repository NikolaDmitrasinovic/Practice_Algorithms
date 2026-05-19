namespace SomeAlgorithms.BasicAlgorithms;

public static class ContainerWithMostWater
{
    /*
     You are given an array of integers:
     int[] height
     
     Each number represents the height of a vertical line.
     You must choose two lines that form a container with the x-axis, and return the maximum amount of water the container can hold.

     Example:
     Input:  [1,8,6,2,5,4,8,3,7]
     Output: 49

     Why 49?
     Choose height 8 at index 1 and height 7 at index 8.

     width  = 8 - 1 = 7 (distance between positions)
     height = min(8, 7) = 7 (shorter of the two walls)
     area   = 7 * 7 = 49 (width * height)

     Important rule:
     area = width * shorter height
     Because water spills over the shorter wall.
    */

    public static int MaxArea(int[] heights)
    {
        var left = 0;
        var right = heights.Length - 1;
        var maxArea = 0;

        while (left < right)
        {
            var width = right - left;
            var containerHeight = Math.Min(heights[left], heights[right]);
            var area = containerHeight * width;

            if (maxArea < area)
                maxArea = area;

            if (heights[left] < heights[right])
                left++;
            else 
                right--;
        }

        return maxArea;
    }
}