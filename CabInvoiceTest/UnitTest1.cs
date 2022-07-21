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
    }
}