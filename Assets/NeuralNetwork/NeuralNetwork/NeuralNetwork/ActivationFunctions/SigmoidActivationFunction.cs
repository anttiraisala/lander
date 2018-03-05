﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArtificialNeuralNetwork.ActivationFunctions
{
    public class SigmoidActivationFunction : IActivationFunction
    {
        public double CalculateActivation(double signal)
        {
            return 1.0 / (1.0 + Math.Exp(-signal));
        }
    }
}
