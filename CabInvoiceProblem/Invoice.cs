using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceProblem
{
    public class Invoice
    {
        public const double RatePerKm = 10,
                            MinFair = 5,
                            RatePerMin = 1;
        public double RideFair(double km , double min)
        {
            double fair = km * RatePerKm + min * RatePerMin;
            if (fair >= MinFair)
            {
                return fair;
            }
            else
            {
                return MinFair;
            }
        }
        public double MultipleRideFair(double km , double min , int NoOfRide)
        {
             double fair = (km * RatePerKm + min * RatePerMin) * NoOfRide;
            if (fair >= MinFair)
            {
                return fair;
            }
            else
            {
                return MinFair;
            }
        }
    }
}
