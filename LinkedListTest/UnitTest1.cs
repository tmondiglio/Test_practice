namespace LinkedListTest;
using Classes;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Classes.LinkedList<int> l = new Classes.LinkedList<int>(1);
        Assert.Pass();
    }
}