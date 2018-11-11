using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("**********************************Task 1 BMI Calculator******************************");
            Console.WriteLine("*************************************************************************************\n");
            /*Write a method that calculates the BMI.
            The method should accept two arguments – the weight(in kilograms) and the height(in centimetres).
            The method needs to return a number and be displayed from the main method, ie.the BMI.*/
            Console.Write("Enter your height in m: ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter your weight in kg: ");
            double weight = Convert.ToDouble(Console.ReadLine());

            double result = Math.Round(CalcBMI(height, weight), 1);
            Console.WriteLine($"Your BMI is: {result}");           

            Console.ReadLine();
        }
        static double CalcBMI(double h, double w)
        {
            return  w /(h * h);           
        }
    }
}
