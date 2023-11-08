public class Solution {
    public bool CanJump(int[] nums) {
        int maxReach = 0;

        for(int i = 0 ; i < nums.Length ; i++)
        {
            if(maxReach < i) return false;

            maxReach = Math.Max(maxReach, i + nums[i]);

            if(maxReach >= nums.Length - 1)
                return true;
        }
        return true;
    }
}

// The logic for determining if you can reach the last index in an integer array is based on a greedy approach. Here's an explanation of the logic used in the provided code:

// 1. Initialize maxReach to 0. This variable keeps track of the maximum position you can reach from your current position.

// 2. Iterate through the array using a for loop. At each step, consider the current index i.

// 3. Inside the loop:

// 	a. Check if the current index i is greater than maxReach. If it is, it means you cannot reach the current position, and you return false. This is because if i is not reachable, then any position beyond i is also not reachable.
// 	b. Update maxReach by taking the maximum of the current maxReach and i + nums[i]. This represents the farthest position you can reach from the current position i.

// 4. After the loop, if the value of maxReach is greater than or equal to the last index of the array (nums.Length - 1), it means you can reach the last index, so you return true.

// 5. If none of the conditions for returning true are met by the end of the loop, you return false.

// The key idea here is to iteratively update maxReach as you move through the array. 
// If at any point, you find an index that is beyond your maxReach, it's impossible to reach the last index, and you return false. 
// If you successfully traverse the entire array without violating this condition, you return true, indicating that you can reach the last index. 
// This approach is efficient and doesn't require explicitly calculating all possible paths.