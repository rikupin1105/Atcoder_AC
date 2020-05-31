public class Solution
{
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        var max = candies.Max();
        bool[] boollist = new bool[candies.Length];
        for (int i = 0; i < candies.Length; i++)
        {
            if (candies[i] + extraCandies >= max)
            {
                boollist[i] = true;
            }
            else
            {
                boollist[i] = false;
            }
        }
        return boollist;
    }
}