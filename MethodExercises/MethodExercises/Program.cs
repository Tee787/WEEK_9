using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("************************************Task 1***********************************");
            Console.WriteLine("*****************************************************************************");

            double weight, height;

            Console.WriteLine("Please enter your weight in kgs: ");
            weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter your height in cm: ");
            height = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine(BMI(weight, height));
        }
        static public double BMI(double w, double h)
        {
            return w / (h * h);
        }

        
    }
}
