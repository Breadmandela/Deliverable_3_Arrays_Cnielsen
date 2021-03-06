﻿/*
 * Author: Christian Nielsen
 * Date:2/5/2020
 * Description: An iterative array of numbers from 1 to 25 using autopopulate
 */
using System;

namespace Deliverable_3_Arrays_Cnielsen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring ArrayLength as a variable to hold the length of the iterative array
            const int ArrayLength = 25;

            //Declare variable to start array from
            int Start = 1;

            //Declaring the array named as NumberArray
            int[] NumbersArray = new int[ArrayLength];

            //Message to explain what is about to execute
            Console.WriteLine("Using a loop to step through an autopopulated array of length 25");

            //Small graphic for easier reading
            Console.WriteLine("_________________________________________");

            //Executing a for loop to iterate through the array
            for(int i= 0; i <= ArrayLength - 1 ; i+= 1)
            {
                //Display the values in the array
                NumbersArray[i] = Start;                
                Console.WriteLine("Element value =" + " " + NumbersArray[i]);
                Start += 1;
                
            }//End of for loop

            //Small graphic for easier reading
            Console.WriteLine("________________________________________");

            //Pause program until user presses any key
            Console.WriteLine("Press any key to continue");
            Console.ReadKey(true);
        }
    }
}
