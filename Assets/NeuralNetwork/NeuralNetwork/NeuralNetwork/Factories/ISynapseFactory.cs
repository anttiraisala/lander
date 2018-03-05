﻿using System;
namespace ArtificialNeuralNetwork.Factories
{
    public interface ISynapseFactory
    {
        Synapse Create();
        Synapse Create(double weight);
    }
}
