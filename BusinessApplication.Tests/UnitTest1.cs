using Xunit;
using BusinessApplication; 

public class SampleTests
{
    [Fact]
    public void SampleTest_Passes()
    {
        int result = 2 + 3;
        Assert.Equal(5, result);
    }
}