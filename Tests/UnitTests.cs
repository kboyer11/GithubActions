namespace GithubActionsLab;

[TestClass]
public class CalculatorTests
{
    [TestMethod]
    public void Add_Valid_Boyer()
    {
        Assert.AreEqual(3, Program.Add("1", "2"));
        Assert.AreEqual(5, Program.Add("3", "2"));
        Assert.AreEqual(12, Program.Add("5", "7"));
    }

    [TestMethod]
    public void Add_Invalid_Boyer()
    {
        Assert.ThrowsException<FormatException>(() => Program.Add("1", "a"));
        Assert.ThrowsException<FormatException>(() => Program.Add("a", "1"));
        Assert.ThrowsException<FormatException>(() => Program.Add("a", "a"));
    }

    [TestMethod]
    public void Add_Null_Boyer()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Add("1", null));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, "1"));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, null));
    }

    [TestMethod]
    public void Subtract_Valid_Boyer()
    {
        Assert.AreEqual(3, Program.Subtract("5", "2"));
        Assert.AreEqual(-1, Program.Subtract("2", "3"));
        Assert.AreEqual(0, Program.Subtract("7", "7"));
    }

    [TestMethod]
    public void Subtract_Invalid_Boyer()
    {
        Assert.ThrowsException<FormatException>(() => Program.Subtract("1", "a"));
        Assert.ThrowsException<FormatException>(() => Program.Subtract("a", "1"));
        Assert.ThrowsException<FormatException>(() => Program.Subtract("a", "a"));
    }

    [TestMethod]
    public void Multiply_Valid_Boyer()
    {
        Assert.AreEqual(6, Program.Multiply("2", "3"));
        Assert.AreEqual(0, Program.Multiply("0", "9"));
        Assert.AreEqual(-8, Program.Multiply("-2", "4"));
    }

    [TestMethod]
    public void Multiply_Invalid_Boyer()
    {
        Assert.ThrowsException<FormatException>(() => Program.Multiply("1", "a"));
        Assert.ThrowsException<FormatException>(() => Program.Multiply("a", "1"));
        Assert.ThrowsException<FormatException>(() => Program.Multiply("a", "a"));
    }

    [TestMethod]
    public void Divide_Valid_Boyer()
    {
        Assert.AreEqual(2, Program.Divide("6", "3"));
        Assert.AreEqual(2.5, Program.Divide("5", "2"));
        Assert.AreEqual(-4, Program.Divide("-8", "2"));
    }

    [TestMethod]
    public void Divide_Invalid_Boyer()
    {
        Assert.ThrowsException<FormatException>(() => Program.Divide("1", "a"));
        Assert.ThrowsException<FormatException>(() => Program.Divide("a", "1"));
        Assert.ThrowsException<FormatException>(() => Program.Divide("a", "a"));
    }

    [TestMethod]
    public void Power_Valid_Boyer()
    {
        Assert.AreEqual(9, Program.Power("2", "3"));
        Assert.AreEqual(1, Program.Power("5", "0"));
        Assert.AreEqual(9, Program.Power("3", "2"));
    }

    [TestMethod]
    public void Power_Invalid_Boyer()
    {
        Assert.ThrowsException<FormatException>(() => Program.Power("1", "a"));
        Assert.ThrowsException<FormatException>(() => Program.Power("a", "1"));
        Assert.ThrowsException<FormatException>(() => Program.Power("a", "a"));
    }
}