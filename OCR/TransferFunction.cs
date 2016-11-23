using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCR
{
    class TransferFunction
    {
        public enum Type { Sigmoid, Hyperbolic };
        public static Type functionType;
        public static double slope = 1;

        public static double evaluate(double value)
        {
            if (functionType == Type.Sigmoid)
                return evaluteSigmoid(value*slope);
            else
                return evaluteHyperbolic(value);
        }

        public static double evaluateDerivative(double value)
        {
            if (functionType == Type.Sigmoid)
                return evaluteDerivateSigmoid(value*slope);
            else
                return evaluteDerivateHyperbolic(value);
        }

        private static double evaluteSigmoid(double value) 
	    {
		    return 1 / (1 + Math.Pow(Math.E, - value));
	    }

	    private static double evaluteDerivateSigmoid(double value) 
	    {
            return (value - Math.Pow(value, 2));
	    }

        private static double evaluteHyperbolic(double value) 
	    {
		    return Math.Tanh(value);
	    }

        private static double evaluteDerivateHyperbolic(double value) 
	    {
		    return 1 - Math.Pow(Math.Tanh(value), 2);
	    }
    }
}
