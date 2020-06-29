using System;
using Xunit;

namespace Demo.AzFunc.Tests
{
    public class AzFuncTests
    {
        [Fact]
        public void DummyTest()
        {
            Console.WriteLine($"*** Dummy Test - {Demo.AzFunc.Startup.Info} ***");
        }
    }
}
