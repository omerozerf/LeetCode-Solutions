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

## Solution 1: Use Two Dictionaries

This approach uses two dictionaries to count character frequencies for each string and then compares them.

### Complexity
- **Time**: `O(N)` where N is the length of the strings.
- **Space**: `O(1)` (bounded by alphabet size, 26 lowercase letters).

```csharp
public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length) return false;
        
        var firstSDictionary = new Dictionary<char, int>();
        var secondSDictionary = new Dictionary<char, int>();

        for (int index = 0; index < s.Length; index++)
        {
            var myChar = s[index];
            if (firstSDictionary.TryGetValue(myChar, out int value))
            {
                value++;
                firstSDictionary[myChar] = value;
            }
            else
            {
                firstSDictionary.Add(myChar, 1);
            }
        }

        for (int index = 0; index < t.Length; index++)
        {
            var myChar = t[index];
            if (secondSDictionary.TryGetValue(myChar, out int value))
            {
                value++;
                secondSDictionary[myChar] = value;
            }
            else
            {
                secondSDictionary.Add(myChar, 1);
            }
        }

        foreach (KeyValuePair<char, int> kvp in firstSDictionary)
        {
            var firstValue = firstSDictionary[kvp.Key];

            if (secondSDictionary.TryGetValue(kvp.Key, out int secondValue))
            {
                if (firstValue == secondValue) continue;
                return false;
            }
            else
            {
                return false;
            }
        }

        return true;
    }
}
```

## Solution 2: Use One Dictionary

This optimized approach uses a single dictionary. It increments counts for the first string and decrements for the second string. If the dictionary is empty (or all counts are zero) at the end, they are anagrams.

### Complexity
- **Time**: `O(N)`
- **Space**: `O(1)`

```csharp
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
```
