namespace Shuffle_the_Array
{
    public class Solution
    {
        public int[] Shuffle(int[] numArray, int n)
        {
            int[] xArray = new int[n * 2];
            int[] yArray = new int[n * 2];

            for (int i = 0; i < n; i++)
            {
                xArray[i] = numArray[i];
                yArray[i] = numArray[i + n];
                
                int[] answerArray = 
            }
        }
    }
}