namespace GithubActionsLab;

[TestClass]
public class Addition
{
	[TestMethod]
	public void Add_Valid_Patino()
	{
		Assert.AreEqual(3, Program.Add("1", "2"));
		Assert.AreEqual(5, Program.Add("3", "2"));
		Assert.AreEqual(12, Program.Add("5", "7"));
	}
	
    	[TestMethod]
    	public void Subtract_Valid_Monson()
    	{
	        Assert.AreEqual(-1, Program.Subtract("1", "2"));
	        Assert.AreEqual(1, Program.Subtract("3", "2"));
	        Assert.AreEqual(7, Program.Subtract("10", "3"));
    	}

    	[TestMethod]
    	public void Multiply_Valid_Monson()
    	{
	        Assert.AreEqual(2, Program.Multiply("1", "2"));
	        Assert.AreEqual(18, Program.Multiply("6", "3"));
	        Assert.AreEqual(35, Program.Multiply("5", "7"));
    	}

    	[TestMethod]
    	public void Divide_Valid_Monson()
    	{
	        Assert.AreEqual(1, Program.Divide("2", "2"));
	        Assert.AreEqual(3, Program.Divide("9", "3"));
	        Assert.AreEqual(15, Program.Divide("75", "5"));
    	}	

    	[TestMethod]
    	public void Power_Valid_Monson()
    	{
        	Assert.AreEqual(2, Program.Power("1", "2"));
        	Assert.AreEqual(9, Program.Power("3", "2"));
        	Assert.AreEqual(78125, Program.Power("5", "7"));
    	}
	
	[TestMethod]
	public void Add_Invalid_Patino()
	{
		Assert.ThrowsException<FormatException>(() => Program.Add("1", "a"));
		Assert.ThrowsException<FormatException>(() => Program.Add("a", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Add("a", "a"));
	}

	[TestMethod]
	public void Add_Null_Patino()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add("1", null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, "1"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, null));
	}
}
