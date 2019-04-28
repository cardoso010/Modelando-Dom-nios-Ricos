using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;

namespace PaymentContext.Tests
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var subscription = new Subscription(null);
            var student = new Student("Gabriel", "Cardoso", "00000000000", "gabriel.cardoso@test.com");
            student.AddSubscription(subscription);
        }
    }
}
