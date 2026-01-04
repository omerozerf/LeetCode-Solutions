# [242. Valid Anagram](https://leetcode.com/problems/valid-anagram/)

![Difficulty](https://img.shields.io/badge/Difficulty-Easy-green)

## Description

Given two strings `s` and `t`, return `true` if `t` is an anagram of `s`, and `false` otherwise.

An **Anagram** is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.

### Example 1:
```
Input: s = "anagram", t = "nagaram"
Output: true
```

### Example 2:
```
Input: s = "rat", t = "car"
Output: false
```

### Constraints:

- `1 <= s.length, t.length <= 5 * 10^4`
- `s` and `t` consist of lowercase English letters.

## Solution

### Complexity
- **Time**: `O(N)`
- **Space**: `O(1)` (since the character set is limited to lowercase English letters, space is effectively constant/bounded)

```csharp
namespace Valid_Anagram
{
    public class Solution
    {
        public bool IsAnagram(string firstString, string secondString)
        {
            if (firstString.Length != secondString.Length)
                return false;
    
            var frequencyDic = new Dictionary<char, int>();
    
            for (var index = 0; index < firstString.Length; index++)
            {
                var firstChar = firstString[index];
    
                if (frequencyDic.ContainsKey(firstChar))
                {
                    frequencyDic[firstChar]++;
                }
                else
                {
                    frequencyDic.Add(firstChar, 1);
                }
            }
    
            for (var index = 0; index < secondString.Length; index++)
            {
                var secondChar = secondString[index];
    
                if (frequencyDic.TryGetValue(secondChar, out int value))
                {
                    value--;
                    if (value == 0)
                        frequencyDic.Remove(secondChar);
                    else 
                        frequencyDic[secondChar] = value;
                }
                else
                {
                    return false;
                }
            }
    
            return frequencyDic.Count == 0;
        }
    }
}
```
