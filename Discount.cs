using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testproject
{
    public class Discount
    {
        public double calculateDiscount(double SalesInINR)
        {
            double TotalAmount = 0.0;
            if (SalesInINR == 0 || SalesInINR < 0)
            {
                throw new ArgumentException(" Sales Amount should not be 'Zero/Negative'");
            }
            else if (SalesInINR >= 1000 && SalesInINR < 2000)
            {
                TotalAmount = SalesInINR - (SalesInINR * 0.05);
            }
            else if (SalesInINR >= 2000 && SalesInINR < 5000)
            {
                TotalAmount = SalesInINR - (SalesInINR * 0.1);
            }
            else if (SalesInINR >= 5000 && SalesInINR < 20000)
            {
                TotalAmount = SalesInINR - (SalesInINR * 0.5);
            }
            else
            {
                // No Discount  
                TotalAmount = SalesInINR - 0.0;
            }
            return TotalAmount;
        }
    }
}
