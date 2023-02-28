namespace RemoveDuplicatesSortedArray.Tests;

[TestClass]
public class UnitTest1
{

    private readonly Class1 _test;

    public UnitTest1()
    {
        _test = new Class1();
    }

    [TestMethod]
    public void TestMethod1()
    {
        int[] nums = { 1, 1, 2 };

        int result = _test.RemoveDuplicates(nums);

        Assert.AreEqual(2, result);
    }
    [TestMethod]
    public void TestMethod2()
    {
        int[] nums = { 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 3, 3, 4 };

        int result = _test.RemoveDuplicates(nums);

        Assert.AreEqual(5, result);
    }
    [TestMethod]
    public void TestMethod3()
    {
        int[] nums = { 0, 1, 1, 2, 2, 3, 3, 4, 4, 4, 5, 5, 5, 6, 6, 6, 7, 7, 7, 8, 8, 8, 9, 9, 10 };

        int result = _test.RemoveDuplicates(nums);

        Assert.AreEqual(11, result);
    }
}