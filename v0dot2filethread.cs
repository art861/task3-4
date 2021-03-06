﻿using System;
using System.Collections.Generic;
using System.IO;

namespace v0dot2fileread
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

            try {
                string[] lines = File.ReadAllLines("students.txt");
                int i = 0;
                Array.Sort(lines, StringComparer.InvariantCulture);
                foreach (string line in lines)
                {
                    String[] data = line.Split(' ');
                    studentName.Add(data[0]);
                    studentSurname.Add(data[1]);
                    homeWorkOneMarks.Add(int.Parse(data[2]));
                    homeWorkTwoMarks.Add(int.Parse(data[3]));
                    homeWorkThreeMarks.Add(int.Parse(data[4]));
                    homeWorkFourMarks.Add(int.Parse(data[5]));
                    homeWorkFiveMarks.Add(int.Parse(data[6]));
                    examResults.Add(int.Parse(data[7]));

                }

                Console.WriteLine("\n");


                Console.WriteLine("Student Name" + "\t\t" + "Surname" + "\t\t" + "Final points (Avg.)" );
                Console.WriteLine("------------------------------------------------------------ ");



                for (i = 0; i < studentName.Count; i++)
                {
                    double studentMarks = homeWorkOneMarks[i] + homeWorkTwoMarks[i] + homeWorkThreeMarks[i] + homeWorkFourMarks[i] + homeWorkFiveMarks[i];
                    double finalPointAvg = ((0.3) * (studentMarks / 5)) + (0.7 * examResults[i]);

                    var items = new[] { homeWorkOneMarks[i], homeWorkTwoMarks[i], homeWorkThreeMarks[i], homeWorkFourMarks[i], homeWorkFiveMarks[i] };

                    Array.Sort(items);
                    int medianMarks = items[2];

                    //   Console.Write(medianMarks + "");
                    double finalPointMedian = ((0.3) * (medianMarks)) + (0.7 * examResults[i]);
                    //  Console.Write(finalPointMedian + "");
                    //  Console.WriteLine(string.Format("{0,-21}   {1,-13}  {2,5}    {2,18}", "asdasdadsa", "sqweqweadad", Math.Round(5.676, 2), Math.Round(22.222, 2)));

                    Console.WriteLine(string.Format("{0,-21}   {1,-13}  {2,5}    ", studentName[i], studentSurname[i], Math.Round(finalPointAvg, 2)));

                    //  Console.WriteLine(studentName[i] + "     " + studentSurname[i] + "      " + Math.Round(finalPointAvg, 2) + " / " + Math.Round(finalPointMedian, 2));


                }

            }

            catch (Exception e)
            {
                Console.WriteLine("There was an error : ", e.ToString());
            }





        }
    }
}
