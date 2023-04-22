public class Solution 
{
    public int[] GetConcatenation(int[] nums)
    {
        int[] concatenationArray = new int[nums.Length * 2];

        for (int i = 0; i < nums.Length; i++)
        {
            concatenationArray[i] = nums[i];
            concatenationArray[nums.Length + i] = nums[i];
        }

        return concatenationArray;
    }
}