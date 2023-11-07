public class Solution {
    public void Rotate(int[] nums, int k) {
        // k %= nums.Length;

        // if (k == nums.Length || k == 0 || nums.Length == 1)
        //     return;

        // int halfValue = k / 2;
        // bool right = false;
        // if (k < halfValue)
        //     right = true;
        // else
        // {
        //     right = false;
        //     k = nums.Length - k;
        // }

        // // Right Rotate
        // if (right)
        // {
        //     for (int i = 0; i < k; i++)
        //     {
        //         int lastElement = nums[nums.Length - 1];
        //         int j = nums.Length - 1;
        //         while (j > 0)
        //         {
        //             nums[j] = nums[j - 1];
        //             j--;
        //         }
        //         nums[0] = lastElement;
        //     }
        // }
        // else
        // {
        //     // Left Rotate
        //     for (int i = 0; i < k; i++)
        //     {
        //         int firstElement = nums[0];
        //         int j = 0;
        //         while (j < nums.Length - 1)
        //         {
        //             nums[j] = nums[j + 1];
        //             j++;
        //         }
        //         nums[nums.Length - 1] = firstElement;
        //     }
        // }

        void Reverse(int[] nums, int left, int right)
        {
            while (left < right)
            {
                int temp = nums[left];
                nums[left] = nums[right];
                nums[right] = temp;
                left++;
                right--;
            }
        }

        int n = nums.Length;
        k = k % n; // reduce k to the smallest positive integer equivalent

        Reverse(nums, 0, n - 1);

        Reverse(nums, 0, k - 1);

        Reverse(nums, k, n - 1);
    }
}