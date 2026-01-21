using System;

/*
    Problem : Container With Most Water

    Description :
        Given n non-negative integers representing heights of vertical lines, 
        find two lines that together with the x-axis form a container such that 
        the container contains the most water.

    Difficulty : Medium

    Approach:
        Use the Two Pointer technique.

        Initialize two pointers:
        - i at the beginning
        - j at the end

        At every step:
        1. Calculate the area formed by the lines at i and j:
        area = min(height[i], height[j]) * (j - i)
        2. Update maxArea if this area is greater.
        3. Move the pointer pointing to the smaller height:
        - If height[i] < height[j], increment i
        - Else, decrement j

        Why this works:
        The width always decreases as pointers move inward.
        So to potentially get a larger area, we must increase the height.
        Moving the smaller height pointer is the only way to possibly find a taller line.

        This avoids brute force O(n²) and solves the problem in one pass.

    Time Complexity: O(n)
    Space Complexity: O(1)

    Pattern: Two Pointers / Greedy
*/

#region Container With Most Water Sol
public class Solution
{
    public int MaxArea(int[] height)
    {
        int maxArea = 0;
        int i = 0, j = height.Length - 1;

        while (i < j)
        {
            int low = Math.Min(height[i], height[j]);
            maxArea = Math.Max(maxArea, low * (j - i));

            if (height[i] > height[j])
                j--;
            else
                i++;
        }

        return maxArea;
    }
}
#endregion
