using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArtificialNeuralNetwork.ActivationFunctions
{
    public class IdentityActivationFunction : IActivationFunction
    {
        public double CalculateActivation(double signal)
        {
            return signal;
        }
    }
}
