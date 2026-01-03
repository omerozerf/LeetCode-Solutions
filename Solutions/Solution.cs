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