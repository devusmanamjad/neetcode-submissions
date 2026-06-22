public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        for (int p1 = 0; p1 < numbers.Length; p1++)
        {
         int numberToFind = target - numbers[p1];
         for(int p2 = p1+1; p2 < numbers.Length; p2++)
         {
            if(numberToFind == numbers[p2])
            {
                return [p1+1,p2+1];
            }
         }
        }
        return null;
    }
}
