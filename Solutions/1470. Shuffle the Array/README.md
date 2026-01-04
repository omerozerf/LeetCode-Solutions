# [1470. Shuffle the Array](https://leetcode.com/problems/shuffle-the-array/)

![Difficulty](https://img.shields.io/badge/Difficulty-Easy-green)

## Description

Given the array `nums` consisting of `2n` elements in the form `[x1,x2,...,xn,y1,y2,...,yn]`.

Return the array in the form `[x1,y1,x2,y2,...,xn,yn]`.

### Example 1:
```
Input: nums = [2,5,1,3,4,7], n = 3
Output: [2,3,5,4,1,7] 
Explanation: Since x1=2, x2=5, x3=1, y1=3, y2=4, y3=7 then the answer is [2,3,5,4,1,7].
```

### Example 2:
```
Input: nums = [1,2,3,4,4,3,2,1], n = 4
Output: [1,4,2,3,3,2,4,1]
```

### Example 3:
```
Input: nums = [1,1,2,2], n = 2
Output: [1,2,1,2]
```

### Constraints:

- `1 <= n <= 500`
- `nums.length == 2n`
- `1 <= nums[i] <= 10^3`

## Solution

### Complexity
- **Time**: `O(N)`
- **Space**: `O(N)`

```csharp
namespace Shuffle_the_Array
{
    public class Solution
    {
        public int[] Shuffle(int[] numArray, int n)
        {
            int[] xArray = new int[n * 2];
            int[] yArray = new int[n * 2]; // Note: This seems unused in the final logic but present in original code. 
            // Correct approach uses a single result array. 
            // Below is a cleaned up version of the intended logic based on the original file.
            
            int[] result = new int[2 * n];
            for (int i = 0; i < n; i++)
            {
                result[2 * i] = numArray[i];
                result[2 * i + 1] = numArray[n + i];
            }
            return result;
        }
    }
}
```
> [!NOTE]
> The original code in `Solution.cs` had some unused variables and incomplete logic. I have provided a corrected version here for the README documentation while respecting the original file's namespace.
