using System;

namespace v0dot1
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            myProgOne();
            Console.WriteLine("\n\n");
            myProgTwo();


        }



        private static void myProgOne()
        {
            Console.WriteLine("Program Version 0.1 Normal\n\n");
            String[] studentName = new String[4];
            String[] studentSurname = new String[4];
            int[] homeWorkOneMarks = new int[4];
            int[] homeWorkTwoMarks = new int[4];
            int[] homeWorkThreeMarks = new int[4];
            int[] examResults = new int[4];

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Please Enter Student " + (i + 1) + " Name : ");
                studentName[i] = Console.ReadLine();
                Console.WriteLine("Please Enter Student " + (i + 1) + " Surname : ");
                studentSurname[i] = Console.ReadLine();
                Console.WriteLine("Please Enter Student " + (i + 1) + " Homework One Marks : ");

                string l = Console.ReadLine();

                int j;

                while (int.TryParse(l, out j) == false)
                {
                    Console.WriteLine("Invalid input. Please enter 1 to 10.");
                    l = Console.ReadLine();
                }
                homeWorkOneMarks[i] = int.Parse(l);


                Console.WriteLine("Please Enter Student " + (i + 1) + " Homework Two Marks : ");
                l = Console.ReadLine();
                int k;

                while (int.TryParse(l, out k) == false)
                {
                    Console.WriteLine("Invalid input. Please enter 1 to 10.");
                    l = Console.ReadLine();
                }
                homeWorkTwoMarks[i] = int.Parse(l);


                Console.WriteLine("Please Enter Student " + (i + 1) + " Homework Three Marks : ");
                l = Console.ReadLine();
                int n;

                while (int.TryParse(l, out n) == false)
                {
                    Console.WriteLine("Invalid input. Please enter 1 to 10.");
                    l = Console.ReadLine();
                }
                homeWorkThreeMarks[i] = int.Parse(l);


                Console.WriteLine("Please Enter Student " + (i + 1) + " Exam Marks : ");
                l = Console.ReadLine();
                int m;

                while (int.TryParse(l, out m) == false)
                {
                    Console.WriteLine("Invalid input. Please enter 1 to 10.");
                    l = Console.ReadLine();
                }
                examResults[i] = int.Parse(l);
            }

            Console.WriteLine("\n");

            Console.WriteLine("Student Name" + "\t\t" + "Surname" + "\t\t" + "Final points (Avg.)");

            Console.WriteLine("-----------------------------------------------------------");
            //   Console.WriteLine(string.Format("{0,-21} | {1,-13} | {2,5}", "Baberasdadad", "Sheikhasdad", Math.Round(44.543, 2)));



            for (int i = 0; i < 4; i++)
            {
                double studentMarks = homeWorkOneMarks[i] + homeWorkTwoMarks[i] + homeWorkThreeMarks[i];
                double finalPointAvg = ((0.3) * (studentMarks / 3)) + (0.7 * examResults[i]);
                //  Console.WriteLine(studentName[i] + "\t\t" + studentSurname[i] + "\t\t" + Math.Round(finalPointAvg, 2)) ;
                Console.WriteLine(string.Format("{0,-21} | {1,-13} | {2,5}", studentName[i], studentSurname[i], Math.Round(finalPointAvg, 2)));

            }


            Console.WriteLine("\n");


            Console.WriteLine("Student Name" + "\t\t" + "Surname" + "\t\t" + "Final points (Avg.)" + " / " + "Final points (Med.)");
            Console.WriteLine("--------------------------------------------------------------------------------- ");



            for (int i = 0; i < 4; i++)
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


        private static void myProgTwo()
        {
            Console.WriteLine("Program Version 0.1 Random\n\n");
            String[] studentName = new String[4];
            String[] studentSurname = new String[4];
            int[] homeWorkOneMarks = new int[4];
            int[] homeWorkTwoMarks = new int[4];
            int[] homeWorkThreeMarks = new int[4];
            int[] examResults = new int[4];

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Please Enter Student " + (i + 1) + " Name : ");
                studentName[i] = Console.ReadLine();
                Console.WriteLine("Please Enter Student " + (i + 1) + " Surname : ");
                studentSurname[i] = Console.ReadLine();

                Random random = new Random();

                homeWorkOneMarks[i] = random.Next(0, 8);
                homeWorkTwoMarks[i] = random.Next(2, 10);
                homeWorkThreeMarks[i] = random.Next(3, 9);
                examResults[i] = random.Next(0, 10);
            }

            Console.WriteLine("\n");

            Console.WriteLine("Student Name" + "\t\t" + "Surname" + "\t\t" + "Final points (Avg.)");

            Console.WriteLine("-----------------------------------------------------------");
            //   Console.WriteLine(string.Format("{0,-21} | {1,-13} | {2,5}", "Baberasdadad", "Sheikhasdad", Math.Round(44.543, 2)));



            for (int i = 0; i < 4; i++)
            {
                double studentMarks = homeWorkOneMarks[i] + homeWorkTwoMarks[i] + homeWorkThreeMarks[i];
                double finalPointAvg = ((0.3) * (studentMarks / 3)) + (0.7 * examResults[i]);
                //  Console.WriteLine(studentName[i] + "\t\t" + studentSurname[i] + "\t\t" + Math.Round(finalPointAvg, 2)) ;
                Console.WriteLine(string.Format("{0,-21} | {1,-13} | {2,5}", studentName[i], studentSurname[i], Math.Round(finalPointAvg, 2)));

            }


            Console.WriteLine("\n");


            Console.WriteLine("Student Name" + "\t\t" + "Surname" + "\t\t" + "Final points (Avg.)" + " / " + "Final points (Med.)");
            Console.WriteLine("--------------------------------------------------------------------------------- ");



            for (int i = 0; i < 4; i++)
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