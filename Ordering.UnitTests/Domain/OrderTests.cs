using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ordering.ObjectMothers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ordering.UnitTests.Domain
{
    [TestClass]
    class OrderTests
    {
        [TestMethod]
        public void CheckCreateOrderNotFail()
        {
            // Arrange
            var order = OrderObjectMother.CreateOrder();

            // Act


            // Assert
        }
    }
}
