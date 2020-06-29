using System;
using Xunit;

namespace Demo.Api.Tests
{
    public class ApiTests
    {
        [Fact]
        public void DummyTest()
        {
            Console.WriteLine($"*** Dummy Test - {Demo.Api.Startup.Info} ***");
        }
    }
}
