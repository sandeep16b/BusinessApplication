using Xunit;
using BusinessApplication; 

public class HomeControllerTests
{
    [Fact]
    public void Index_Success()
    {
        int result = 2 + 3;
        Assert.Equal(5, result);
    }
    [Fact]
    public void Index_Fail()
    {
        int result = 2 + 3;
        Assert.NotEqual(4, result);
    }

}