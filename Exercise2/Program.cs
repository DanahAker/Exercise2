
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var query = new List<int> { 10, 20, 30 }.Transform(x => x / 10);
        foreach(var value in query)
        {
            Console.WriteLine(value);
        }
    }
}


    public delegate int TransformationFunction(int input);

    public static class Transformation
    {
        public static IEnumerable<int> Transform(this IEnumerable<int> input, TransformationFunction transformationFunction)
        {
            foreach (var value in input)
            {
                yield return transformationFunction(value);
            }
        }
    }



