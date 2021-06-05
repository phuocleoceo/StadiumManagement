using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer.LinearRegression
{
    public class LinearRegression
    {
        private readonly double[] _AverageCustomer;
        private readonly IEnumerable<PricePerCustomer> _PricePerCustomer;
        private readonly double avgX;
        private readonly double avgY;
        public LinearRegression()
        {
            GetData gd = new GetData();
            _AverageCustomer = gd.GetAverageCustomer();
            _PricePerCustomer = gd.GetPricePerCustomer();
            avgX = _PricePerCustomer.Average(c => c.TotalCus);
            avgY = _PricePerCustomer.Average(c => c.TotalPrice);
        }

        // y = ax + b
        public void CalculateCoefficient(out double a, out double b)
        {
            double x = 0, y = 0;
            foreach (PricePerCustomer i in _PricePerCustomer)
            {
                x += (i.TotalCus - avgX) * (i.TotalPrice - avgY);
                y += (i.TotalCus - avgX) * (i.TotalCus - avgX);
            }
            a = x / y;
            b = avgY - a * avgX;
        }

        public double[] PredictSalePerDayWeek()
        {
            CalculateCoefficient(out double a, out double b);
            double[] predict = new double[7];
            for(int i = 0; i < 7; i++)
            {
                if (_AverageCustomer[i] == 0) predict[i] = 0;
                else predict[i] = Math.Round(_AverageCustomer[i] * a + b);
            }
            return predict;
        }
    }
}
