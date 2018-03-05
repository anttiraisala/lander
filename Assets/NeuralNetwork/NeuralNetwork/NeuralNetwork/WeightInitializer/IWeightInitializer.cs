using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArtificialNeuralNetwork.WeightInitializer
{
    public interface IWeightInitializer
    {
        double InitializeWeight();
    }
}
