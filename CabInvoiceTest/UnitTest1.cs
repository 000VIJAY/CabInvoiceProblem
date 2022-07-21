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
        public void MultipleRideFairTest()
        {
            Invoice invoice = new Invoice();
           var rsult =  invoice.MultipleRideFair(10, 20, 3);
            Assert.AreEqual(360, rsult);      
        }
    }
}