using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ArtificialNeuralNetwork.Perceptron
{
    class Program
    {
        static void Main(string[] args)
        {
            Perceptron p;
            p = new Perceptron();
            p.SetInputs(12, 4);
            p.SetWeights(0.5, -1);

            var guess = p.Guess();
        }
    }
}
