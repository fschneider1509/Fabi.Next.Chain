using System;
using Xunit;

namespace Fabi.Next.Chain.Lib.Tests
{
    class TestClass 
    {
        public string Value1 { get; set; }
        public int Value2 { get; set; }
    }
    public class UnitTest1
    {
        [Fact]
        public void ShouldChangeProperties()
        {
            var t = new TestClass
            {
                Value1 = "Before",
                Value2 = 0
            };

            t.Next(o => o);

            Assert.True(t.Value1 == "After");
        }
    }
}
