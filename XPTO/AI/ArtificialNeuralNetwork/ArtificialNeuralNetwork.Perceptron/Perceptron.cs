using System;
using System.Collections.Generic;
using System.Text;

namespace ArtificialNeuralNetwork.Perceptron
{
    public class Perceptron
    {
        private int[] _inputs;
        private double[] _weights;


        public void SetInputs(params int[] inputs)
        {
            _inputs = inputs;
        }

        public void SetWeights(params double[] weights)
        {
            _weights = weights;
        }


        //Sum all of the weighted inputs
        private double SumAllweighted()
        {
            double sum = 0;

            for (int i = 0; i < _inputs.Length; i++)
            {
                //For every input, multiply that input by its weight.
                sum += _inputs[i] * _weights[i];
            }

            return sum;
        }

        public int Guess()
        {
            //Compute the output of the perceptron based on that sum passed through an activation function (the sign of the sum)

            var sum = SumAllweighted();

            var output = Activate(sum);

            return output;

        }

        private void RecalculateWeights()
        {

        }

        private int Activate(double sum)
        {
            if (sum < 0)
                return -1;

            return 1;
        }
    }
}
