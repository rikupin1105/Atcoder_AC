public class Solution
{
    public string DefangIPaddr(string address)
    {
        var add = address.Split('.');
        return String.Join("[.]", add);
    }
}