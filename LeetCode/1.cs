public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var arrayAns = new int[2];
        for (int i = 0; i < nums.Count(); i++)
        {
            for (int j = i + 1; j < nums.Count(); j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    arrayAns[0] = i;
                    arrayAns[1] = j;
                }
            }
        }
        return arrayAns;
    }
}