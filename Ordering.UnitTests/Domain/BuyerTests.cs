using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ordering.ObjectMothers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ordering.UnitTests.Domain
{
    [TestClass]
    class BuyerTests
    {
        [TestMethod]
        public void CheckCreateBuyerNotFail()
        {
            var post = BuyerObjectMother.CreateBuyer();
        }
    }
}
