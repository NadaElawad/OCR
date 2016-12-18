using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCR
{
    class TransferFunction
    {
        public enum Type { Sigmoid, Hyperbolic, Signum, Linear };
        public Type functionType;
        public static double slope = 1;

        public TransferFunction(Type type)
        {
            this.functionType = type;
        }

        public double evaluate(double value)
        {
            if (functionType == Type.Sigmoid)
                return evaluteSigmoid(value * slope);
            else if (functionType == Type.Hyperbolic)
                return evaluteHyperbolic(value);
            else if (functionType == Type.Signum)
                return evaluateSignum(value);
            else
                return evaluateLinear(value);
        }

        public double evaluateDerivative(double value)
        {
            if (functionType == Type.Sigmoid)
                return evaluteDerivateSigmoid(value*slope);
            else
                return evaluteDerivateHyperbolic(value);
        }

        private double evaluateSignum(double value)
        {
            if (value > 0) return 1;
            return -1;
        }

        private double evaluateLinear(double value)
        {
            return value;
        }

        private double evaluteSigmoid(double value) 
	    {
		    return 1 / (1 + Math.Pow(Math.E, - value));
	    }

	    private double evaluteDerivateSigmoid(double value) 
	    {
            return slope * (value - Math.Pow(value, 2));
	    }

        private double evaluteHyperbolic(double value) 
	    {
		    return Math.Tanh(value);
	    }

        private double evaluteDerivateHyperbolic(double value) 
	    {
		    return 1 - Math.Pow(Math.Tanh(value), 2);
	    }
    }
}
