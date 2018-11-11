using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("*************************************Task 2***********************************");
            Console.WriteLine("******************************************************************************");
            Console.Write("Please enter your height: ");
            double height = double.Parse(Console.ReadLine());           //double.Parse used
            Console.Write("Please enter your weight: ");
            double weight = double.Parse(Console.ReadLine());

            double result = Math.Round(BMICalc(height, weight), 1);     //BMICalc method being called with decimal rounding of output.
            Console.WriteLine(result);                                  //Console.WriteLine used to output result

            string output = Classify(result);                           //String Method output being recalled 
            Console.WriteLine(Classify(result));                        //Another example using Console.WriteLine instead
        }/*When using methods, must remember when using "void", there will be no calling of the method. If you want to call a method to be used,
        we must utilise a statement instead (string, double, float, decimal, bool), Name our method accordingly with an name to our code, and arguments to be used inside the brackets.
        If we use statements instead of void, we must return a result in our method. Failure to return a result will end up with a broken code*/
        static double BMICalc(double h, double w)                       //BMICalc method being used to output our result for BMI
        {
            return w / (h * h);                                        //return output for our BMI calculation
        }
        /*Our second method used in our code to return result output with "if and if else" statements used. We must end the last part of our code with a "else statement, otherwise
         * our code will not work and we'll have build errors*/
        static string Classify(double _result)                      //Declaring our method with a string and Name, with an argument inside the brackets
        {
            if (_result < 18.5)                                     //If and if else statements used to output or intended results
                return "underweight";
            else if (_result >= 18.5 && _result < 25)
                return "Normal Weight";
            else if (_result >= 25 && _result < 30)
            {
                return "Overweight";
            }
            else
                return "Obese";                                     //Must finish with "else" statement to avoid build errors and broken code
        }
    }
}
