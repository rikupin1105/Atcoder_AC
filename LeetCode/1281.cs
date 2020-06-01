public class Solution
{
    public int SubtractProductAndSum(int n)
    {
        var times = 1;
        var sum = 0;
        var s = n.ToString();
        for (int i = 0; i < s.Length; i++)
        {
            times *= int.Parse(s[i].ToString());
            sum += int.Parse(s[i].ToString());
        }
        return times - sum;
    }
}