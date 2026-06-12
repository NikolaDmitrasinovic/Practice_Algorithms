namespace BasicAlgorithms;

public static class LongestSubstring
{
    /*
     * Given a string s, return the length of the longest substring that contains no repeated characters.
     * s = "abcabcbb"
     * Longest substring without repeats is "abc", so result is: 3
     */
    public static int LengthOfLongestSubstring1(string input)
    {
        var left = 0;
        var right = 0;
        var maxLength = 0;
        
        var substring = new List<char>();

        while (right < input.Length)
        {
            if (substring.Contains(input[right]))
            {
                substring.Remove(input[left]);
                left++;
            }
            else
            {
                substring.Add(input[right]);
                right++;

                var currentLength = right - left;
                maxLength = Math.Max(maxLength, currentLength);
            }
        }

        return maxLength;
    }
    
    // better version (HashSet<char>)
    public static int LengthOfLongestSubstring(string s)
    {
        var left = 0;
        var maxLength = 0;
        var seen = new HashSet<char>();

        for (var right = 0; right < s.Length; right++)
        {
            while (seen.Contains(s[right]))
            {
                seen.Remove(s[left]);
                left++;
            }
            
            seen.Add(s[right]);
            
            var currentLength = right - left + 1;
            maxLength = Math.Max(maxLength, currentLength);
        }
        
        return maxLength;
    }
    
    // time complexity: O(n)
    // space complexity: O(min(n, k)) - n=length of string, k=number of possible unique characters
    // For normal ASCII could be O(1) because k i capped. Gor general / Unicode it is safer to say O(n)
    
    // Map solution
    public static int LengthOfLongestSubstringMapp(string s)
    {
        var left = 0;
        var maxLength = 0;
        var lastSeen = new Dictionary<char, int>();

        for (var right = 0; right < s.Length; right++)
        {
            var current =  s[right];

            if (lastSeen.ContainsKey(current) && lastSeen[current] >= left)
                left = lastSeen[current] + 1;

            lastSeen[current] = right;

            maxLength = Math.Max(maxLength, right - left + 1);
        }
        
        return maxLength;
    }
}