using System;
using Xunit;
namespace tpXunit
{
    public class Class1
    {
        [Fact]
        public void PassingTest()
        {
            Assert.Equal(4, Add(2,2));
        }
        [Fact]
        public void FaillingTest()
        {
            Assert.Equal(5, Add(2,2));

        }

        int Add(int x, int y)
        {
            return x + y;
        }
        public void MyFirstTheory(int value){
            Assert.True(IsOdd(value));
        }
        bool IsOdd(int value)
        {
            return value %2 == 1;
        }
    }
}
