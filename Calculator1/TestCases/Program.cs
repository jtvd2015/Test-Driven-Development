using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaxTechnicalTraining.Bootcamp.DotNet.TestDrivenDevelopment.Jen;

namespace TestCases
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool allTestsPassed = TestForZeroInputs();
            allTestsPassed &= TestForOneInput();
            allTestsPassed &= TestForValidInputs();
            allTestsPassed &= TestForMoreThanTenInputs();

            if (allTestsPassed)
            {
                Console.WriteLine("All tests passed.");
            }
            else
            {
                Console.WriteLine("Some tests failed.");
            }
            Console.ReadKey();
        }

        private static bool TestForMoreThanTenInputs()
        {
            string userInput = "1, 3393, 8543, 9432, 2160, 6112, 7597, 2568, 2493, 7869, 2";
            string ApplicationExceptionThrown = "No Exception";
            Calculator calulator = new Calculator();
            try
            {
                //should throw an ApplicationException
                calulator.Add(userInput);
            }
            catch (ApplicationException ex)
            {
                ApplicationExceptionThrown = "ApplicationException";
            }
            bool passed = PrintTestResult("15", "Test for more than ten inputs", "ApplicationException", ApplicationExceptionThrown);
            return passed;
        }

        private static bool TestForValidInputs()
        {
            string userInput = "3, 5";
            Calculator calculator = new Calculator();
            int sum = calculator.Add(userInput);
            bool passed = PrintTestResult("3", "Test for valid inputs", "8", sum.ToString());
            userInput = "9, 21";
            sum = calculator.Add(userInput);
            passed &= PrintTestResult("4", "Test for valid inputs", "30", sum.ToString());

            //three inputs
            userInput = "3, 8, 12";
            sum = calculator.Add(userInput);
            passed &= PrintTestResult("5", "Test for valid inputs", "23", sum.ToString());

            userInput = "9, 21, 10";
            sum = calculator.Add(userInput);
            passed &= PrintTestResult("6", "Test for valid inputs", "40", sum.ToString());

            userInput = "2120, 4372, 8437";
            sum = calculator.Add(userInput);
            passed &= PrintTestResult("7", "Test for valid inputs", "14929", sum.ToString());

            //four inputs
            userInput = "8751, 3398, 2807, 6258";
            sum = calculator.Add(userInput);
            passed &= PrintTestResult("8", "Test for valid inputs", "21214", sum.ToString());

            //five inputs
            userInput = "5779, 3909, 604, 5908, 1045";
            sum = calculator.Add(userInput);
            passed &= PrintTestResult("9", "Test for valid inputs", "17245", sum.ToString());

            //six inputs
            userInput = "3306, 8109, 8917, 4632, 4696, 9550";
            sum = calculator.Add(userInput);
            passed &= PrintTestResult("10", "Test for valid inputs", "39210", sum.ToString());

            //seven inputs
            userInput = "5563, 1703, 494, 3093, 648, 3841, 5104";
            sum = calculator.Add(userInput);
            passed &= PrintTestResult("11", "Test for valid inputs", "20446", sum.ToString());

            //eight inputs
            userInput = "8996, 826, 2402, 3825, 2313, 4667, 8451, 2144";
            sum = calculator.Add(userInput);
            passed &= PrintTestResult("12", "Test for valid inputs", "33624", sum.ToString());

            //nine inputs
            userInput = "3752, 2056, 1086, 4631, 547, 5945, 5674, 6009, 2234";
            sum = calculator.Add(userInput);
            passed &= PrintTestResult("13", "Test for valid inputs", "31934", sum.ToString());

            //ten inputs
            userInput = "1, 3393, 8543, 9432, 2160, 6112, 7597, 2568, 2493, 7869";
            sum = calculator.Add(userInput);
            passed &= PrintTestResult("14", "Test for valid inputs", "50168", sum.ToString());

            return passed;
        }

        private static bool TestForOneInput()
        {
            string userInput = "100";
            string ApplicationExceptionThrown = "No Exception";
            Calculator calulator = new Calculator();
            try
            {
                //should throw an ApplicationException
                calulator.Add(userInput);
            }
            catch (ApplicationException ex)
            {
                ApplicationExceptionThrown = "ApplicationException";
            }
            bool passed = PrintTestResult("2", "Test for one inputs", "ApplicationException", ApplicationExceptionThrown);
            return passed;
        }

        private static bool TestForZeroInputs()
        {
            string userInput = "";
            string ApplicationExceptionThrown = "No Exception";
            Calculator calulator = new Calculator();
            try
            {
                //should throw an ApplicationException
                calulator.Add(userInput);
            }
            catch (ApplicationException ex)
            {
                ApplicationExceptionThrown = "ApplicationException";
            }
            bool passed = PrintTestResult("1", "Test for zero inputs", "ApplicationException", ApplicationExceptionThrown);
            return passed;
        }

        private static bool PrintTestResult(string Id, string Description, string ExpectedResults, string ActualResults)
        {
            string passfail = ExpectedResults == ActualResults ? "PASS" : "FAIL";
            Console.WriteLine($"{Id} {Description} {ExpectedResults} {ActualResults} {passfail}");
            return passfail == "PASS";
        }
    }
}