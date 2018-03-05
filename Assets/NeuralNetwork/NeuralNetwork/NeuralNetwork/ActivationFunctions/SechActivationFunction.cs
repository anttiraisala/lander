using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArtificialNeuralNetwork.ActivationFunctions
{
    public class SechActivationFunction : IActivationFunction
    {
        public double CalculateActivation(double signal)
        {
            return (1 / Math.Cosh(signal));
        }
    }
}
