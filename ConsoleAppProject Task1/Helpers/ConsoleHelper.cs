using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject
{
    public static class ConsoleHelper
    {
        /// <summary>
        /// The user selecting their choice 
        /// </summary>
        public static int SelectChoice(String[] choices)
        {
            // Display all choices
            int choiceNo = 0;

            foreach (string choice in choices)
            {
                choiceNo++;
                Console.WriteLine($"     {choiceNo}.  {choice}");
            }

            // Get the User's choice 

            Console.Write("Please enter your choice > ");
            string value = Console.ReadLine();
            choiceNo = Convert.ToInt32(value);

            return choiceNo;
        }

        /// <summary>
        /// Outputs the heading for all the apps
        /// </summary>
        public static void OutputHeading(string title)
        {
            Console.WriteLine("\n------------------------------------------");
            Console.WriteLine($"             {title}                       ");
            Console.WriteLine("\n-----------By Amir Mohamed----------------");
            Console.WriteLine("\n------------------------------------------");
        }
    }
}