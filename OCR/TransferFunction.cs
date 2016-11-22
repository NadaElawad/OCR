using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCR
{
    class TransferFunction
    {
        public static double evaluteSigmoid(double value) 
	    {
		    return 1 / (1 + Math.Pow(Math.E, - value));
	    }

	    public static double evaluteDerivateSigmoid(double value) 
	    {
		    return (value - Math.Pow(value, 2));
	    }

        public static double evaluteHyperbolic(double value) 
	    {
		    return Math.Tanh(value);
	    }

        public static double evaluteDerivateHyperbolic(double value) 
	    {
		    return 1 - Math.Pow(value, 2);
	    }
    }
}
