using System;
using System.Collections.Generic;

/*

Problem : Two Sum

Description : Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

Difficulty: Easy

Approach:
Use a HashMap to store numbers and their indices while iterating.
For each element, calculate the required complement (target - current value).
If the complement exists in the map, return the indices.
Otherwise, store the current value and index in the map.
This avoids a brute-force O(n²) approach and solves it in one pass.

Time Complexity: O(n)

Space Complexity: O(n)

Pattern: HashMap / Complement lookup

*/

/* Solution */

#region Two Sum Sol
public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        int n = nums.Length;

        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < n; i++)
        {

            int balance = target - nums[i];
            if (map.ContainsKey(balance))
            {
                return new int[] { map[balance], i };
            }

            map[nums[i]] = i;
        }

        return new int[] { };
    }
}

#endregion