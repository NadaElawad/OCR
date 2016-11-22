using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCR
{
    class HelperFunctions
    {
        public static double[] ToDoubleArray(string[] lines)
        {
            double[] ret = new double[lines.Length*lines.Length];
            for (int i = 0; i < lines.Length; i++)
            {
                for (int j = 0; j < lines[i].Length; j++)
                {
                    if (lines[i][j] == '1') ret[i * lines.Length + j] = 1;
                    else ret[i * lines.Length + j] = 0;
                }
            }
            return ret;
        }
        public static void Normalize(ref double[] input)
        {
            double mean = 0, absMax = 0;
            for (int i = 0; i < input.Length; i++)
            {
                mean += input[i];
                absMax = Math.Max(absMax, input[i]);
            }
            mean /= input.Length;

            for (int i = 0; i < input.Length; i++)
            {
                input[i] = (input[i] - mean) / absMax;
            }
        }
    }
}
