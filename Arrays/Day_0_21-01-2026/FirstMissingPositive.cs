using System;

/*
Problem : First Missing Positive

Description :
Given an unsorted integer array nums, find the smallest missing positive integer.
You must solve it in O(n) time and use constant extra space.

Difficulty : Hard

Approach:
Use Index Mapping (Cyclic Sort idea).

For an array of size n:
The answer must lie in the range [1, n + 1].

Each valid number x should ideally be placed at index:
    x - 1

Algorithm:
1. Traverse the array.
2. While:
   - nums[i] is positive
   - nums[i] is within array bounds (≤ n)
   - nums[i] is not already in its correct position
   Swap nums[i] with nums[nums[i] - 1].
3. After rearrangement, traverse again:
   - The first index i where nums[i] != i + 1
     → return i + 1.
4. If all positions are correct, return n + 1.

This rearranges elements in-place and guarantees linear time.

Time Complexity: O(n)
Each element is swapped at most once into its correct position.

Space Complexity: O(1)
No extra data structures are used.

Pattern:
Index Mapping / Cyclic Sort / In-place Hashing
*/

#region First Missing Positive Sol
public class Solution
{
    private void Swap(int[] nums, int i, int j)
    {
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }

    public int FirstMissingPositive(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            while (nums[i] > 0 && nums[i] <= nums.Length && nums[nums[i] - 1] != nums[i])
            {
                Swap(nums, i, nums[i] - 1);
            }
        }

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != i + 1)
                return i + 1;
        }

        return nums.Length + 1;
    }
}
#endregion
