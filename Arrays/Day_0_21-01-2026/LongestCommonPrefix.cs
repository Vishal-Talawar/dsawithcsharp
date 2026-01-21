using System;

/*
    Problem : Longest Common Prefix

    Description :
        Write a function to find the longest common prefix string amongst an array of strings.
        If there is no common prefix, return an empty string "".

    Difficulty : Easy

    Approach:
        Use a prefix shrinking technique.
        Start by assuming the first string as the initial prefix.
        Then compare this prefix with each string in the array.

        For every string:
          - While the current string does not start with the prefix:
          - Reduce the prefix by removing its last character.
          - Repeat until the prefix matches or becomes empty.

        This works because the longest common prefix must be a prefix of the first string.
        By shrinking it step by step, we ensure it matches all strings.

        This avoids comparing all characters across all strings at once and keeps the solution simple and efficient.

    Time Complexity:
        O(N * M)
            Where:
            - N = number of strings
            - M = length of the longest string
            In the worst case, we may shrink the prefix multiple times for each string.

    Space Complexity:
        O(1)
        Only constant extra space is used.

    Pattern:
        Prefix Shrinking / Vertical Scanning
*/

#region Longest Common Prefix Sol
public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        string prefix = strs[0];

        for (int i = 1; i < strs.Length; i++)
        {
            while (!strs[i].StartsWith(prefix))
            {
                prefix = prefix.Substring(0, prefix.Length - 1);

                if (prefix == "")
                    break;
            }
        }

        return prefix;
    }
}
#endregion
