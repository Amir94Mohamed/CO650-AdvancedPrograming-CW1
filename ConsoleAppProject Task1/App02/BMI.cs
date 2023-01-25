using System;
namespace ConsoleAppProject.App02
{
    /// <summary>
    /// Here in this App it will be a Body Mass Index calculator which will calculate the users height and weight and health risks.
    /// </summary>
    /// <author>
    /// Student Amir Mohamed V1
    /// Amir Mohamed version 0.1
    /// </author>
    public class BMI
    {

        private string unitType;
        public double Feet { get; set; }
        public double Inches { get; set; }
        public double Stones { get; set; }
        public double Pounds { get; set; }
        public double Kilograms { get; set; }
        public double Metres { get; set; }
        public double weightImperial;
        public double heightImperial;
        public double imperialBMI;
        public double metricBMI;

        /// <summary>
        /// Here it will print the heading
        /// </summary>
        public void OutputHeading()
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("------Body Mass Index Calculator------");
            Console.WriteLine("-----------By Amir Mohamed------------");
            Console.WriteLine("--------------------------------------");
        }

        /// <summary>
        /// Here in this method where the BMI will calculate itself.
        /// </summary>
        public void BMICalculation()
        {
            OutputHeading();
            SelectUnit();
            if (unitType == "1")
            {
                InputWeightInImperialUnit();
                InputHeightInImperialUnit();

                ImperialCalculation();
                BMIResults(imperialBMI);
            }
            else if (unitType == "2")
            {
                InputWeightInMetricUnit();
                InputHeightInMetricUnit();

                MetricCalculation();
                BMIResults(metricBMI);
            }
            PrintBAME();
        }

        /// <summary>
        /// In this method it will give the user options to enter his weight in metric unit
        /// </summary>
        private void InputWeightInMetricUnit()
        {
            Console.WriteLine(" Please enter your weight to the nearest KG");
            Console.WriteLine();

            Console.Write(" Enter your weight in KG > ");
            Kilograms = Convert.ToDouble(Console.ReadLine());

        }

        /// <summary>
        /// In this method it will give the user options to enter his height in metric unit
        /// </summary>
        private void InputHeightInMetricUnit()
        {
            Console.WriteLine(" Please enter your height to the nearest Metres");
            Console.WriteLine();

            Console.Write(" Enter your height in Metres > ");
            Metres = Convert.ToDouble(Console.ReadLine());
        }

        /// <summary>
        /// In this method it will give the user options to enter his height in imperial unit
        /// </summary>
        private void InputHeightInImperialUnit()
        {
            Console.WriteLine(" Please enter your height to the nearest feet and inches");
            Console.WriteLine();

            Console.Write(" Enter your height in feet > ");


            Feet = Convert.ToDouble(Console.ReadLine());

            Console.Write(" Enter your height in inches > ");
            Inches = Convert.ToDouble(Console.ReadLine());
        }

        /// <summary>
        /// In this method it will give the user options to enter his weight in imperial unit
        /// </summary>
        private void InputWeightInImperialUnit()
        {
            Console.WriteLine(" Please enter your weight to the nearest stones and pounds");
            Console.WriteLine();

            Console.Write(" Enter your weight in stones > ");
            Stones = Convert.ToDouble(Console.ReadLine());

            Console.Write(" Enter your weight in pounds > ");
            Pounds = Convert.ToDouble(Console.ReadLine());
        }

        /// <summary>
        /// Here the user will choose which unit they would like to choose
        /// </summary>
        private void SelectUnit()
        {
            Console.WriteLine(" Please choose which unit you would like?");
            Console.WriteLine(" 1. Imperial unit ");
            Console.WriteLine(" 2. Metric unit ");
            Console.Write(" Please input your choice > ");
            unitType = Console.ReadLine();
        }

        /// <summary>
        /// Here is where the imperial calculation happens
        /// </summary>
        public void ImperialCalculation()
        {
            double newPounds = Stones * 14;
            weightImperial = Pounds + newPounds;

            double newInches = Feet * 12;
            heightImperial = Inches + newInches;

            imperialBMI = (weightImperial * 703) / (heightImperial * heightImperial);
        }

        /// <summary>
        /// here is where the metric calculation happens
        /// </summary>
        public void MetricCalculation()
        {
            metricBMI = (Kilograms) / (Metres * Metres);
        }

        /// <summary>
        /// here the BMI result will discover if you are underweight, overweight, normal or which obese class 1 to 3
        /// </summary>
        /// <param name="BMI"></param>
        public void BMIResults(double BMI)
        {
            BMI = Math.Round(BMI, 2);
            if (BMI <= 18.5)
            {
                Console.WriteLine(" Your BMI result is " + BMI);
                Console.WriteLine();
                Console.WriteLine(" You are UNDERWEIGHT! ");
            }
            else if (BMI >= 18.5 && BMI <= 24.9)
            {
                Console.WriteLine(" Your BMI result is " + BMI);
                Console.WriteLine();
                Console.WriteLine(" You are NORMAL! ");
            }
            else if (BMI >= 25 && BMI <= 29.9)
            {
                Console.WriteLine(" Your BMI result is " + BMI);
                Console.WriteLine();
                Console.WriteLine(" You are OVERWEIGHT! ");
            }
            else if (BMI >= 30 && BMI <= 34.9)
            {
                Console.WriteLine(" Your BMI result is " + BMI);
                Console.WriteLine();
                Console.WriteLine(" You are OBESE CLASS 1! ");
            }
            else if (BMI >= 35 && BMI <= 39.9)
            {
                Console.WriteLine(" Your BMI result is " + BMI);
                Console.WriteLine();
                Console.WriteLine(" You are OBESE CLASS 2! ");
            }
            else if (BMI >= 40)
            {
                Console.WriteLine(" Your BMI result is " + BMI);
                Console.WriteLine();
                Console.WriteLine(" You are OBESE CLASS 3! ");
            }
        }

        /// <summary>
        /// this method it will print the BAME. 
        /// </summary>
        public void PrintBAME()
        {
            Console.WriteLine("If you are Black, Asian or other ethnic groups,\n\r" +
                              "you have a higher risk.\n\r\n\r" +
                              "Adults 23 or more are at INCREASED RISK.\n\r" +
                              "Adults 27.5 or more are at HIGH RISK.\n\r\n\r");
        }

    }
}