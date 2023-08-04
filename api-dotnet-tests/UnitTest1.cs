using System;
using Xunit;
using api_dotnet.Models;

namespace api_dotnet_tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
        var order = new Order{
            Id = 1,
            OrderDate = new DateTime(2023, 10, 1),
            Status = OrderStatus.Draft
            };
            var text = order.ToString();
            Assert.Equal(text, text);
        }
    }
}
