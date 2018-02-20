using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRPNCalculator
{
    internal class Program
    {
        private static double answer;

        private static bool TestValidOperations()
        {
            string equation = "1,2,+";
            bool success = RPNCalculator.Calculator.Evaluate(equation, out answer);
            string actual = success ? "TRUE" : "FALSE";
            return TestResult("1", "1 2 + Input", "3", answer.ToString());
        }

        private static bool TestInput()
        {
            string equation = "";
            bool success = RPNCalculator.Calculator.Evaluate(equation, out answer);
            string actual = success ? "TRUE" : "FALSE";
            return TestResult("1", "Empty Input", "FALSE", actual);
        }

        private static bool TestResult(string Id, string Description, string Expected, string Actual)
        {
            string passed = (Expected == Actual) ? "PASS" : "FAIL";
            Console.WriteLine($"{Id} | {Description} | {Expected} | {Actual} | {passed}");
            return passed == "PASS";
        }

        private static void Main(string[] args)
        {
            bool AllTestsPassed = true;
            AllTestsPassed &= TestInput();
            AllTestsPassed &= TestValidOperations();
            Console.ReadKey();
        }
    }
}