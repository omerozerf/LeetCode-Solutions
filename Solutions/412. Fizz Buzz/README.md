# [412. Fizz Buzz](https://leetcode.com/problems/fizz-buzz/)

![Difficulty](https://img.shields.io/badge/Difficulty-Easy-green)

## Description

Given an integer `n`, return a string array `answer` (**1-indexed**) where:

- `answer[i] == "FizzBuzz"` if `i` is divisible by `3` and `5`.
- `answer[i] == "Fizz"` if `i` is divisible by `3`.
- `answer[i] == "Buzz"` if `i` is divisible by `5`.
- `answer[i] == i` (as a string) if none of the above conditions are true.

### Example 1:
```
Input: n = 3
Output: ["1","2","Fizz"]
```

### Example 2:
```
Input: n = 5
Output: ["1","2","Fizz","4","Buzz"]
```

### Example 3:
```
Input: n = 15
Output: ["1","2","Fizz","4","Buzz","Fizz","7","8","Fizz","Buzz","11","Fizz","13","14","FizzBuzz"]
```

### Constraints:

- `1 <= n <= 10^4`

## Solution

### Complexity
- **Time**: `O(N)`
- **Space**: `O(1)` (excluding the output list)

```csharp
public class Solution {

    public bool CheckFizz(int n){
        bool isFizz = n % 3 == 0;
        return isFizz;
    }

    public bool CheckBuzz(int n){
        bool isBuzz = n % 5 == 0;
        return isBuzz;
    }

    public IList<string> FizzBuzz(int n) {
        var fizzS = "Fizz";
        var buzzS = "Buzz";
        var fizzAndBuzzS = "FizzBuzz";
        IList<string> myList = new List<string>();

        for (int i = 1; i <=n ; i++)
        {
            var isFizz = CheckFizz(i);
            var isBuzz = CheckBuzz(i);

            if (isFizz && isBuzz) {
                myList.Add(fizzAndBuzzS);
                continue;
            }
            else if (isFizz){
               myList.Add(fizzS);
                continue;
            }
            else if (isBuzz){
                myList.Add(buzzS);
                continue;
            }
            else
            {
                myList.Add(i.ToString());
                continue;
            }
        }

        return myList;
    }
}
```
