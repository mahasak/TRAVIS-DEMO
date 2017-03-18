using System;
using Xunit;

namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        }

        [Fact]
        public void TestAdd() {
            Assert.Equal(2, add(1,1));
        }

        //Test feature
        public int add(int a, int b) {
            return a+b;
        }
    }
}
