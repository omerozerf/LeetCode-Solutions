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