namespace TestProject1;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.True(true);
    }
    
    [Fact]
    public void FalseIsFalse()
    {
        //this was dumb
        Assert.False(true);
        Assert.True(false);
    }
}

