using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    class Program
    {//week 3 Problem 1 Kody, Angel, Katie
        static void Main(string[] args)
        {
            BMIindex();//calls the BMIIndex method

        }

        static void BMIindex()
        {
            Console.WriteLine("What is your height in inches?");//ask user for their height in inches
            double height = Convert.ToDouble(Console.ReadLine());//stores users height after converting to double
            Console.WriteLine("What is your weight in pounds?");//asks user for their weight in pounds
            double weight = Convert.ToDouble(Console.ReadLine());//stores users weight after converting to a double
            double BMI = weight * 703 / (height * height);//Calculates users BMI using their height and weight
            if(BMI < 18.5)//if user is underweight this happens
            {
                Console.WriteLine($"You're BMI is {BMI}. You are underweight!");//tells user their BMI and underweight
            } 
            else if(25 >= BMI && BMI >= 18.5)//if user is good weight this happens
            {
                Console.WriteLine($"You're BMI is {BMI}. You are at an optimal weight. Great job!");
                // tells user their BMI and good weight

            }
            else if(BMI > 25) //if user is overweight this happens
            {
                Console.WriteLine($"You're BMI is {BMI}. You are overweight.");
            }//tells user their bmi and they're overweight
        }
    }
}
