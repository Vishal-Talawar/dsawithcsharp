using System;

/*
Problem : Remove Duplicates from Sorted Array

Description :
Given a sorted integer array nums, remove the duplicates in-place such that each unique element appears only once.
Return the number of unique elements. The first k elements of nums should contain the final result.

Difficulty : Easy

Approach:
Use the Two Pointer technique.

Maintain:
- unique → points to the last unique element’s index
- scanner → scans through the array to find new unique elements

Steps:
1. Start both pointers:
   - unique at index 0
   - scanner at index 1
2. For every element at scanner:
   - If nums[scanner] is different from nums[unique]:
     - Increment unique
     - Copy nums[scanner] to nums[unique]
3. Continue until scanner reaches the end.
4. The number of unique elements is unique + 1.

This works because the array is already sorted, so all duplicates appear consecutively.
We overwrite duplicates in-place and keep only unique values at the front.

Time Complexity: O(n)
Space Complexity: O(1)

Pattern: Two Pointers / In-place Array Update
*/

#region Remove Duplicates Sol
public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        if (nums.Length == 0)
            return 0;

        int unique = 0, scanner = 1;

        while (scanner < nums.Length)
        {
            if (nums[scanner] != nums[unique])
            {
                unique++;
                nums[unique] = nums[scanner];
            }
            scanner++;
        }

        return unique + 1;
    }
}
#endregion
