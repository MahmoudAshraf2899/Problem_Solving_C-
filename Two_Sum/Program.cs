
int[] TwoSum(int[] nums, int target)
{
    int[] indices = { }; //Empty Array Of Int

    for (int i = 0; i < nums.Length; i++)
    {
        for (int j = 0; j < nums.Length; j++)//Nested Loop
        {
            if (i == j)//If We Sum First Element Twice (Like nums[0] + nums[0])
            {
                continue;
            }
            else if (nums[i] + nums[j] == target)//if (item 1  + item 2 ) = targetValue Then Append To Array
            {
                indices = indices.Append(i).ToArray();
            }
        }
    }

    return indices;
}

/*
 *Explanation
   Input: nums = [2,7,11,15], target = 9
    Output: [0,1]
    Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
 */

var arrayOfInteger = new int[4];
arrayOfInteger[0] = 2;
arrayOfInteger[1] = 7;
arrayOfInteger[2] = 11;
arrayOfInteger[3] = 15;
TwoSum(arrayOfInteger, 9);