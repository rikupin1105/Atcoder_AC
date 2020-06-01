public class Solution
{
    public int[] SmallerNumbersThanCurrent(int[] nums)
    {
        var anslist = new List<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            var sum = 0;
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[i] > nums[j])
                {
                    sum++;
                }
            }
            anslist.Add(sum);
        }
        return anslist.ToArray();
    }
}