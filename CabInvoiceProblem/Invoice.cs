using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceProblem
{
    public class EnhencedInvoice
    {
        public readonly double totalFair = 0,
                                totalRides = 0,
                                avg = 0;
        public EnhencedInvoice(double totalFare, double totalRides)
        {
            this.totalFair = totalFare;
            this.totalRides = totalRides;
            avg = totalFare / totalRides;
        }
    }
    public class Ride
    {

        public readonly double km = 0,
                               min = 0;
        public Ride(double km, double Minute)
        {
            this.km = km;
            this.min = Minute;
        }
    }
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
        public EnhencedInvoice MultipleRideFair(List<Ride> rides)
        {
            double fair = 0;
            foreach (var ride in rides)
            {
                fair += RideFair(ride.km, ride.min);
            }
            EnhencedInvoice e1 = new EnhencedInvoice(fair, rides.Count);
            return e1;
        }
    }
}
