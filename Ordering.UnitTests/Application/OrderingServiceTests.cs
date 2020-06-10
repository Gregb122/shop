using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Ordering.API;
using Ordering.Domain.BuyerAggregate.Repository;
using Ordering.Domain.OrderAggregate;
using Ordering.Domain.OrderAggregate.Repository;
using Ordering.ObjectMothers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ordering.UnitTests.Application
{
    [TestClass]
    class OrderingServiceTests
    {
        [TestMethod]
        public void CheckFindMethodCalled()
        {
            // Arrange
            Mock<IOrderRepository> repositoryOrderMock = new Mock<IOrderRepository>();
            Mock<IBuyerRepository> repositoryBuyerMock = new Mock<IBuyerRepository>();
            IOrderingService bs = new OrderingService(repositoryOrderMock.Object, repositoryBuyerMock.Object);

            // Act
            var order = OrderObjectMother.CreateOrder();
            bs.AddOrder(order);

            // Assert
            repositoryOrderMock.Verify(k => k.Add(order), Times.Once());
        }
    }
}
