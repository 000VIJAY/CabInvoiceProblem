
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CabInvoiceProblem;

namespace CabInvoiceTest
{
    [TestClass]
    public class UserInvoice
    {
        [TestMethod]
        public void TestInvoicePerUser()
        {
            int userId = 1;
            InvoiceForeachUser IPU = new InvoiceForeachUser();
            IPU.AddRides(1, new List<Ride>()
            {
                new Ride(20, 30),   //230
                new Ride(2, 3),     //23
                new Ride(12, 16),   //136
                new Ride(5, 7),     //57
                new Ride(19, 23)    //213
            });
            IPU.AddRides(2, new List<Ride>()
            {
                new Ride(20, 30),   //230
                new Ride(2, 3),     //23
                new Ride(12, 16),   //136
                new Ride(5, 7),     //57
                new Ride(19, 23)    //213
            });

            var res = IPU.UserFare(userId);
            Assert.AreEqual(659, res.totalFair);
        }

    }
}
