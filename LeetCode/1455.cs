public class Solution
{
    public int IsPrefixOfWord(string sentence, string searchWord)
    {
        var list = sentence.Split(' ');
        var ans = -1;

        for (int i = 0; i < list.Length; i++)
        {
            try
            {
                var s = list[i].Substring(0, searchWord.Length);
                if (s == searchWord)
                {
                    ans = i + 1;
                    break;
                }

            }
            catch (Exception)
            {

            }
        }

        return ans;
    }
}