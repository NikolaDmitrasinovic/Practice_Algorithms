namespace BasicAlgorithms;

public static class Palindrome
{
    /*
     * You are given a string:
     * string s
     * 
     * You must determine if it is a palindrome, considering only alphanumeric characters and ignoring cases.
     * 
     * Example:
     * Input:  "A man, a plan, a canal: Panama"
     * Output: true
     * 
     * Input:  "race a car"
     * Output: false
     * 
     * Important rule:
     * Only alphanumeric characters are considered, and case is ignored.
    */

    public static bool IsPalindrome(string s)
    {
        var left = 0;
        var right = s.Length -1;

        while (left < right)
        {
            if (!char.IsLetterOrDigit(s[left]))
            {
                left++;
                continue;
            }
            
            if (!char.IsLetterOrDigit(s[right]))
            {
                right--;
                continue;
            }
            
            if (char.ToLowerInvariant(s[left]) != char.ToLowerInvariant(s[right]))
                return false;
            
            left++;
            right--;
        }

        return true;
    }
}
