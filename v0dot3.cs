﻿using System;
using System.Collections.Generic;
using System.IO;

namespace v0dot3
{
    class MainClass
    {
        public static List<students> studentsList = new List<students>();
        public static void Main(string[] args)
        {
            try
            {
                // code that may raise exceptions
                string[] lines = File.ReadAllLines("students.txt");
                Array.Sort(lines, StringComparer.InvariantCulture);
                foreach (string line in lines)
                {
                    String[] data = line.Split(' ');
                    students temp = new students(data[0], data[1], int.Parse(data[2]), int.Parse(data[3]), int.Parse(data[4]), int.Parse(data[5]), int.Parse(data[6]), int.Parse(data[7]));
                    studentsList.Add(temp);

                }
            }
            catch (Exception ex)
            {
                // handle exception
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
                Environment.Exit(0);
                Console.WriteLine("There was an error opening file");
            }
            finally
            {


                try
                { //input of two int numbers num1 and num2 and devision result output
                    Console.WriteLine("\n");
                    Console.WriteLine("Student Name" + "\t\t" + "Surname" + "\t\t" + "Final points (Avg.)");
                    Console.WriteLine("------------------------------------------------------------ ");

                    for (int i = 0; i < studentsList.Count; i++)
                    {
                        double studentMarks = studentsList[i].getH1() + studentsList[i].getH2() + studentsList[i].getH3() + studentsList[i].getH4() + studentsList[i].getH5();
                        double finalPointAvg = ((0.3) * (studentMarks / 5)) + (0.7 * studentsList[i].getExam());
                        Console.WriteLine(string.Format("{0,-21}   {1,-13}  {2,5}    ", studentsList[i].getName(), studentsList[i].getsurName(), Math.Round(finalPointAvg, 2)));

                    }
                }
                catch (DivideByZeroException ex)/* standart exception, raised when
                an integer value is divide by zero*/
                {
                    Console.Write("Cannot divide by zero. Please try again.");
                }
                catch (InvalidOperationException ex)/* standart exception, raised
                when a method call is invalid in an object's current state.*/
                {
                    Console.Write("Not a valid number. Please try again.");
                }
                catch (FormatException ex)/* standart exception, raised when a
                value is not in an appropriate format to be converted from a
                string by a conversion method such as Parse.*/
                {
                    Console.Write("Not a valid number. Please try again.");
                }
            }

           
        }
    }
}
