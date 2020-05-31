public class Solution
{
    public int NumJewelsInStones(string J, string S)
    {
        var ans = 0;
        var list = new List<char>();
        for (int i = 0; i < J.Length; i++)
        {
            list.Add(J[i]);
        }
        for (int i = 0; i < list.Count; i++)
        {
            ans += CountChar(S, list[i]);
        }
        return ans;
    }
    public static int CountChar(string s, char c)
    {
        return s.Length - s.Replace(c.ToString(), "").Length;
    }
}