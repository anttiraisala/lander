﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArtificialNeuralNetwork.ActivationFunctions
{
    public class SinhActivationFunction: IActivationFunction
    {
        public double CalculateActivation(double signal)
        {
            return Math.Sinh(signal);
        }
    }
}
