using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArtificialNeuralNetwork.ActivationFunctions
{
    public class AbsoluteXActivationFunction : IActivationFunction
    {
        public double CalculateActivation(double signal)
        {
            return Math.Abs(signal);
        }
    }
}
