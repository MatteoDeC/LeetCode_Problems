internal class Solution
{
    public int Reverse(int x)
    {
        var cArr = x.ToString().ToCharArray();
        bool negative = cArr[0] == '-';

        string s = string.Empty;
        int mult = negative ? -1 : 0;
        for (int i = cArr.Length - 1; i >= (-1 * mult); i = i - 1)
        {
            s += cArr[i];
        }
        double num = double.Parse(s);
        int result = num > int.MaxValue ? 0 : Convert.ToInt32(num);
        return negative ? result * (-1) : result;
    }

    public int EfficientReverse(int x)
    {
        int reversed = 0;

        while (x != 0)
        {
            if (reversed < int.MinValue / 10 || reversed > int.MaxValue / 10)
                return 0;

            int lastDigit = x % 10;
            reversed = reversed * 10 + lastDigit;
            x = x / 10;
        }

        return reversed;
    }
}
