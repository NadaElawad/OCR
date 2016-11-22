using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCR
{
    class Layer
    {
        public Neuron[] neurons;
	    public int length;

	    public Layer(int length, int prev)
	    {
		    this.length = length;
		    neurons = new Neuron[length];
		
		    for(int j = 0; j < length; j++)
			    neurons[j] = new Neuron(prev);
	    }
    }
}
