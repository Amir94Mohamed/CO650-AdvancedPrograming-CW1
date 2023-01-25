namespace ConsoleAppProject.App03
{
    /// <summary>
    /// At the moment this class just tests the
    /// Grades enumeration names and descriptions
    /// </summary>
    public class StudentGrades
    {
        //Constants (Grade Boundaries)
        public const int LowestMark = 0;
        public const int LowestGradeD = 40;
        public const int LowestGradeC = 50;
        public const int LowestGradeB = 60;
        public const int LowestGradeA = 70;
        public const int HighestMark = 101;
        private readonly string[] Classification = new string[] {"First Class", "Upper Second Class",
        "Lower Second Class", "Third Class", "Fail",};

        //Properties
        public string[] Students { get; set; }

        public int[] Marks { get; set; }

        public Grades[] Grades { get; set; }

        public double[] GradeProfile { get; set; }

        public double Mean { get; set; }

        public int Minimum { get; set; }

        public int Maximum { get; set; }


        //Attributes

        public StudentGrades()
        {
            Students = new string[]
            {
                "Ali", "Hussein", "Abbas", "Abdul",
                "Yaser", "Mohamed", "Yusif", "Daniel",
                "Alex", "Michael" };
            GradeProfile = new double[5];
            Marks = new int[Students.Length];
        }

        public void RunStudentGrades()
        {
            OutputHeading();

            InputMarks();
            CalculateGrades();
            PrintStudentDetails();
            CalculateMean();
            CalculateGradeProfile();
            PrintStats();
        }

        /// <summary>
        /// 
        /// </summary>
        public void InputMarks()
        {
            Console.WriteLine(" Please enter your marks ");
            for (int i = 0; i < Students.Length; i++)
            {
                Console.WriteLine(" Enter  " + (Students[i]) + "'s Mark:  ");
                Marks[i] = int.Parse(Console.ReadLine());
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void PrintStudentDetails()
        {
            Console.WriteLine();
            Console.WriteLine(" Student Details");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Name | Mark | Grade ");
            Console.WriteLine();

            for (int i = 0; i < Students.Length; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"{Students[i]} | {Marks[i]} | {Grades[i]}");
            }

            Console.WriteLine();
            Console.WriteLine("--------------------------------");
            Console.WriteLine();

        }

        /// <summary>
        /// This method will print the stats such as the Mean, Maximum, Minimum.
        /// </summary>
        public void PrintStats()
        {
            Console.WriteLine(" Stats of Mean, Maximum and Minimum marks ");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("        | Mark      ");
            Console.WriteLine();
            Console.WriteLine($"Mean    | {Mean}    ");
            Console.WriteLine();
            Console.WriteLine($"Maximum | {Maximum} ");
            Console.WriteLine();
            Console.WriteLine($"Minimum | {Minimum} ");
            Console.WriteLine("--------------------------------");


            for (int i = 0; i < GradeProfile.Length; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"{GradeProfile[i]}% - {Classification[i]}");
            }

        }

        /// <summary>
        /// This method calculates the Mean. 
        /// </summary>
        public void CalculateMean()
        {
            double total = 0;

            Maximum = Marks[0];
            Minimum = Marks[0];

            foreach (int mark in Marks)
            {
                if (mark > Maximum)
                {
                    Maximum = mark;
                }
                else if (mark < Minimum)
                {
                    Minimum = mark;
                }

                total += mark;
                Mean = total / 10;

            }
        }

        /// <summary>
        /// This will calculate the grade profile for each student.
        /// </summary>
        public void CalculateGradeProfile()
        {
            GradeProfile = new double[5];

            foreach (var grade in Grades)
            {
                if (grade == App03.Grades.F)
                    GradeProfile[0]++;

                else if (grade == App03.Grades.D)
                    GradeProfile[1]++;

                else if (grade == App03.Grades.C)
                    GradeProfile[2]++;

                else if (grade == App03.Grades.B)
                    GradeProfile[3]++;

                else if (grade == App03.Grades.A)
                    GradeProfile[4]++;

            }

            for (int i = 0; i < GradeProfile.Length; i++)
            {
                GradeProfile[i] = GradeProfile[i] * (100 / Students.Length);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        public void CalculateGrades()
        {
            Grades = new Grades[Students.Length];

            for (int i = 0; i < Marks.Length; i++)
            {
                if (Marks[i] is >= LowestMark and < LowestGradeD)
                    Grades[i] = App03.Grades.F;

                else if (Marks[i] is >= LowestGradeD and < LowestGradeC)
                    Grades[i] = App03.Grades.D;

                else if (Marks[i] is >= LowestGradeC and < LowestGradeB)
                    Grades[i] = App03.Grades.C;

                else if (Marks[i] is >= LowestGradeB and < LowestGradeA)
                    Grades[i] = App03.Grades.B;

                else if (Marks[i] is >= LowestGradeA and < HighestMark)
                    Grades[i] = App03.Grades.A;

            }
        }

        /// <summary>
        /// This will print the heading.
        /// </summary>
        public void OutputHeading()
        {
            Console.WriteLine("\n---------------------------------------");
            Console.WriteLine("\n----------Student Grades---------------");
            Console.WriteLine("\n----------By Amir Mohamed--------------");
            Console.WriteLine("\n---------------------------------------");

        }
    }
}
