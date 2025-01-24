using System;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        [Fact]
        public void AdditionTest()
        {
            Assert.Equal(4, Add(2, 2));
        }
        [Fact]
        public void AdditionTest2()
        {
            Assert.Equal(5, Add(2, 2));
        }
        [Fact]
        public void Test1()
        {

        }
    }
}
