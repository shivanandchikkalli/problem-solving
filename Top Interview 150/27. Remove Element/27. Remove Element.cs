public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int[] s = new int[nums.Length];
        int counter = 0;
        for(int i = 0 ; i < nums.Length ; i++)
        {
            if(nums[i] != val)
                s[counter++] = nums[i];
        }
        int j = 0;
        for(int k = 0 ; k < counter ; k++)
        {
            nums[j++] = s[k];
        }

        return counter;
    }
}