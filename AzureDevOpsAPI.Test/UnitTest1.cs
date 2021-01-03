using AzureDevOpsAPI.Controllers;
using System;
using Xunit;

namespace AzureDevOpsAPI.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var controller = new ValuesController();
            var returnValue = controller.Get(1);
            Assert.Equal("ChandrashekharTodkar", returnValue.Value);
        }
    }
}
