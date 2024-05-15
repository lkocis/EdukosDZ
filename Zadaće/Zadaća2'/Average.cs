using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaća2_
{
    //Refaktoriranje ZAD2
    class Average
    {
        List<double> AddAverages(List<double[]> arrays)
        {
            List<double> averages = new List<double>();
            foreach (double[] a in arrays)
            {
                averages.Add(CalculateAverages(a));
            }
            return averages;
        }

        double CalculateAverages(double[] array)
        {
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
                sum += array[i];
            return sum / array.Length;
        }
    }
}
