using CabInvoiceProblem;
namespace CabInvoiceTest
{
    [TestClass]
    public class CabInvoice
    {
        [TestMethod]
        public void TotalFair()
        {
           Invoice invoice = new Invoice();
            var result = invoice.RideFair(10 ,20);
            Assert.AreEqual(120 , result);
        }
        [TestMethod]
        public void TestMinCabFair()
        {
            Invoice cab = new Invoice();
            var res = cab.RideFair(0.2, 1);
            Assert.AreEqual(5, res);
        }
        [TestMethod]
        public void TestMulCabFair()
        {
            Invoice invoice = new Invoice();
            List<Ride> rides = new List<Ride>()
            {
                new Ride (5 ,20),  //70
                new Ride(2,20),     //40
                new Ride(13 , 5),   //135
                new Ride(5 ,12),    //62
            };
            var res = invoice.MultipleRideFair(rides);
            Assert.AreEqual(307, res.totalFair);
        }
    }
}