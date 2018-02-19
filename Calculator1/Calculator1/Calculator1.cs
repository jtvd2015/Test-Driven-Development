﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxTechnicalTraining.Bootcamp.DotNet.TestDrivenDevelopment.Jen
{
    public class Calculator
    {
        /// <summary>
        /// Adds 2<=x<=10 integers entered on Command Line
        /// </summary>
        /// <param name="numbers">A string of integers separated by commas</param>
        /// <returns>The sum of all the numbers</returns>
        public int Add(string numbers)
        {
            if (numbers.Length == 0)
            {
                throw new ApplicationException("No User Input.");
            }
            string[] numberSubstrings = numbers.Split(',');
            if (numberSubstrings.Count() < 2 || numberSubstrings.Count() > 10)
            {
                throw new ApplicationException("Minimum number is two and maximum is ten.");
            }
            List<int> integers = new List<int>();
            foreach (string str in numberSubstrings)
            {
                int nbr;
                bool converted = int.TryParse(str, out nbr);
                if (converted == false)
                {
                    throw new ApplicationException("Invalid number format.");
                }
                integers.Add(nbr);
            }
            int total = 0;
            foreach (int i in integers)
            {
                total += i;
            }
            return total;
        }
    }
}