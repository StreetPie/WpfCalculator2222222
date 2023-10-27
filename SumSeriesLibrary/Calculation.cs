using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SumSeriesLibrary
{
    public class Calculation
    {
        public double CalculateSumSeries(double x, double eps)
        {
            double sum = 0;
            double term = 1;
            int n = 0;

            while (Math.Abs(term) >= eps)
            {
                sum += term;
                n++;
                term *= x / n;
            }

            return sum;
        }
    }
}