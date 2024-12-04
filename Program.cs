using System;
using System.Collections.Generic;
using System.IO;

namespace Advent_of_Code___Day_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string PATH_TO_INPUT = @"G:\Visual Studio Projects\Advent of Code - Day 1\input.txt";

            int totalSum = 0;

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
                totalSum += Math.Abs(leftValues[i] - rightValues[i]);
            }

            Console.WriteLine(totalSum);
        }
    }
}
