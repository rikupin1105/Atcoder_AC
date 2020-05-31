public class Solution
{
    public bool CanBeEqual(int[] target, int[] arr)
    {
        Array.Sort(target);
        Array.Sort(arr);

        if (string.Join(' ', target) == string.Join(' ', arr))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}