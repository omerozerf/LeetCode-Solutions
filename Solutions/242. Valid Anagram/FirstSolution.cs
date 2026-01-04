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