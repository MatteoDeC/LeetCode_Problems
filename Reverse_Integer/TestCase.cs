internal class TestCase
{
    public static void Test1()
    {
        var result = (new Solution()).Reverse(123);
        Console.WriteLine(result);
    }

    public static void Test2()
    {
        var result = (new Solution()).Reverse(-342);
        Console.WriteLine(result);
    }

    public static void Test3()
    {
        var result = (new Solution()).Reverse(-2147483412);
        Console.WriteLine(result);
    }
}
