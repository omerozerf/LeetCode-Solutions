namespace Build_Array_from_Permutation
{
    public class Solution
    {
        public int[] BuildArray(int[] nums)
        {
            int[] ans = new int[nums.Length];

            for (var number = 0; number < ans.Length; number++)
            {
                ans[number] = nums[nums[number]];
            }

            return ans;
        }
    }
}