using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArtificialNeuralNetwork.ActivationFunctions
{
    public interface IActivationFunction
    {
        double CalculateActivation(double signal);
    }
}
