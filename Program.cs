using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Advent_of_Code___Day_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string PATH_TO_INPUT = @"G:\Visual Studio Projects\Advent of Code - Day 1\input.txt";

            int sumOfDistances = 0;
            int sumOfRepeats = 0;

            List<int> leftValues = new List<int>();
            List<int> rightValues = new List<int>();

            foreach (string line in File.ReadAllLines(PATH_TO_INPUT))
            {
                string[] temp = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                leftValues.Add(Int32.Parse(temp[0]));
                rightValues.Add(Int32.Parse(temp[1]));
            }

            leftValues.Sort();
            rightValues.Sort();

            for (int i = 0; i < leftValues.Count; i++)
            {
                sumOfDistances += Math.Abs(leftValues[i] - rightValues[i]);
            }

            Console.WriteLine($" Summary of distances: {sumOfDistances}");

            foreach (int leftItem in leftValues)
            {
                //int counter = 0;

                //foreach (int rightItem in rightValues)
                //{
                //    if (leftItem == rightItem)
                //    {
                //        ++counter;
                //    }
                //}

                sumOfRepeats += leftItem * rightValues.Count(item => item == leftItem);
            }

            Console.WriteLine($" Summary of repeated values: {sumOfRepeats}");
        }
    }
}
