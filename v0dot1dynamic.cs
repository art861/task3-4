﻿using System;
using System.Collections.Generic;

namespace v0dot1dynamic
{
    class MainClass
    {
        public static void Main(string[] args)
        {

          
            List<String> studentName = new List<String>();
            List<String> studentSurname = new List<String>();
            List<int> homeWorkOneMarks = new List<int>();
            List<int> homeWorkTwoMarks = new List<int>();
            List<int> homeWorkThreeMarks = new List<int>();
            List<int> homeWorkFourMarks = new List<int>();
            List<int> homeWorkFiveMarks = new List<int>();
            List<int> examResults = new List<int>();


            String myInput = "";
            int i = 0;
            while (myInput != "#"  )
            {

                Console.WriteLine("Please Enter Student " + (i + 1) + " Name : ");
                studentName.Add(Console.ReadLine());
                Console.WriteLine("Please Enter Student " + (i + 1) + " Surname : ");
                studentSurname.Add(Console.ReadLine());

                Random random = new Random();

                homeWorkOneMarks.Add(random.Next(0, 8));
                homeWorkTwoMarks.Add(random.Next(2, 10));
                homeWorkThreeMarks.Add(random.Next(3, 9));
                homeWorkFourMarks.Add(random.Next(2, 9));
                homeWorkFiveMarks.Add(random.Next(1, 9));
                examResults.Add(random.Next(0, 10));
                Console.WriteLine("HW Marks and Exam marks are Added Randomly");

                Console.WriteLine("type # to quit or Press Any other key to continue adding students");
                myInput = Console.ReadLine().ToString();
                i++;

            }


            Console.WriteLine("\n");


            Console.WriteLine("Student Name" + "\t\t" + "Surname" + "\t\t" + "Final points (Avg.)" + " / " + "Final points (Med.)");
            Console.WriteLine("--------------------------------------------------------------------------------- ");



            for (i = 0; i < studentName.Count; i++)
            {
                double studentMarks = homeWorkOneMarks[i] + homeWorkTwoMarks[i] + homeWorkThreeMarks[i];
                double finalPointAvg = ((0.3) * (studentMarks / 3)) + (0.7 * examResults[i]);

                var items = new[] { homeWorkOneMarks[i], homeWorkTwoMarks[i], homeWorkThreeMarks[i] };
                var getLengthItems = items.Length;
                Array.Sort(items);
                int medianMarks = items[1];

                double finalPointMedian = ((0.3) * (medianMarks)) + (0.7 * examResults[i]);

                //  Console.WriteLine(string.Format("{0,-21}   {1,-13}  {2,5}    {2,18}", "asdasdadsa", "sqweqweadad", Math.Round(5.676, 2), Math.Round(22.222, 2)));

                Console.WriteLine(string.Format("{0,-21}   {1,-13}  {2,5}    {2,18}", studentName[i], studentSurname[i], Math.Round(finalPointAvg, 2), Math.Round(finalPointMedian, 2)));

                //  Console.WriteLine(studentName[i] + "     " + studentSurname[i] + "      " + Math.Round(finalPointAvg, 2) + " / " + Math.Round(finalPointMedian, 2));


            }

        }
    }
}
