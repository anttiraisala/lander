using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArtificialNeuralNetwork.WeightInitializer
{
    public class ConstantWeightInitializer : IWeightInitializer
    {
        private readonly double _value;

        public ConstantWeightInitializer(double constantValue)
        {
            _value = constantValue;
        }

        public double InitializeWeight()
        {
            return _value;
        }
    }
}
