using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCR
{
    class Layer
    {
        public Neuron[] Neurons;
	    public int Length;
	
	    /**
	     * Layer of Neurons
	     * 
	     * @param l Layer Size
	     * @param prev Size of the previous layer
	     */
	    public Layer(int length, int prev)
	    {
		    this.Length = length;
		    Neurons = new Neuron[length];
		
		    for(int j = 0; j < Length; j++)
			    Neurons[j] = new Neuron(prev);
	    }
    }
}
