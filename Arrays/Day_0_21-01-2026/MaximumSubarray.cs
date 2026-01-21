
using System;


/*
 
    Problem : Maximum SubArray

    Description : Given an integer array nums, find the subarray with the largest sum, and return its sum.

    Difficulty : Medium

    Approach:
        Use Kadane’s Algorithm.
        Maintain two variables:
        - curr: maximum subarray sum ending at current index
        - max: maximum subarray sum found so far

        For each element:
        - Either start a new subarray from the current element
        - Or extend the existing subarray by adding the current element
        Choose the maximum of these two.

        Update the global maximum after every step.
        This converts a brute-force O(n²) solution into a linear-time solution.

    Time Complexity: O(n)

    Space Complexity: O(1)

    Pattern: Kadane’s Algorithm / Dynamic Programming
 
 */


#region Maximum Subarray Sol

public class Solution
{
    public int MaxSubArray(int[] nums)
    {
        int max = nums[0], curr = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {

            curr = Math.Max(nums[i], curr + nums[i]);

            max = Math.Max(max, curr);
        }

        return max;
    }
}

#endregion