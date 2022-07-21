using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CabInvoiceProblem;

namespace CabInvoiceProblem
{
    public class InvoiceForeachUser
    {
        Dictionary<int, List<Ride>> repo = new Dictionary<int, List<Ride>>();

        public EnhencedInvoice UserFare(int userId)
        {
            Invoice cabInvoice = new Invoice();
            List<Ride> invoices = new List<Ride>();

            EnhencedInvoice res = new EnhencedInvoice(0, 0);
            if (repo.ContainsKey(userId))
            {
                invoices = repo[userId];

                if (invoices != null && invoices.Count > 0)
                {
                    res = cabInvoice.MultipleRideFair(repo[userId]);
                }
            }
            return res;
        }

        public void AddRides(int userId, List<Ride> rides)
        {
            List<Ride> invoices = new List<Ride>();
            if (repo.ContainsKey(userId))
            {
                invoices = repo[userId];
            }

            foreach (var ride in rides)
            {
                invoices.Add(ride);
            }
            repo[userId] = invoices;
        }
    }
}
