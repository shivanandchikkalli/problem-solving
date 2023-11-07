public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        
        int[] result = new int[2];
        int start = 0;
        int end = numbers.Length - 1;

        while (start < end)
        {
            if (numbers[start] + numbers[end] == target)
            {
                result[0] = ++start;
                result[1] = ++end;
                break;
            }
            else if (numbers[start] + numbers[end] > target)
                end--;
            else if (numbers[start] + numbers[end] < target)
                start++;
        }

        return result;
    }
}