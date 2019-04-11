using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Application;

namespace v0dot5
{
    class MainClass


    {



        public static List<students> studentsList100 = new List<students>();
        public static List<students> studentsList1000 = new List<students>();
        public static List<students> studentsList10000 = new List<students>();
        public static List<students> studentsList100000 = new List<students>();

        public static LinkedList<students> LLstudentsList100 = new LinkedList<students>();
        public static LinkedList<students> LLstudentsList1000 = new LinkedList<students>();
        public static LinkedList<students> LLstudentsList10000 = new LinkedList<students>();
        public static LinkedList<students> LLstudentsList100000 = new LinkedList<students>();

        public static Queue<students> qstudentsList100 = new Queue<students>();
        public static Queue<students> qstudentsList1000 = new Queue<students>();
        public static Queue<students> qstudentsList10000 = new Queue<students>();
        public static Queue<students> qstudentsList100000 = new Queue<students>();

        public static string firstfilecreation100 = "";
        public static string firstfilecreation1000 = "";
        public static string firstfilecreation10000 = "";
        public static string firstfilecreation100000 = "";

        public static string datasorting100 = "";
        public static string datasorting1000 = "";
        public static string datasorting10000 = "";
        public static string datasorting100000 = "";

        public static string datasplitting100 = "";
        public static string datasplitting1000 = "";
        public static string datasplitting10000 = "";
        public static string datasplitting100000 = "";

        public static string outputofsorted100 = "";
        public static string outputofsorted1000 = "";
        public static string outputofsorted10000 = "";
        public static string outputofsorted100000 = "";

        public static List<students> studentsList = new List<students>();
        public static void Main(string[] args)
        {
            progLLlist();
            progList();
          
            progqlist();






        }

        private static void progList()
        {
            try
            {

                Console.WriteLine("Processing Please Wait ...");
                var watch = new System.Diagnostics.Stopwatch();

                watch.Start();

                for (int i = 0; i < 100; i++)
                {

                    Random rnd = new Random(DateTime.Now.Millisecond);

                    students temp = new students("Name" + (i + 1), "Surname" + (i + 1), rnd.Next(3, 10), rnd.Next(2, 10), rnd.Next(1, 10), rnd.Next(0, 10), rnd.Next(4, 10), rnd.Next(1, 10));
                    studentsList100.Add(temp);
                }

                watch.Stop();

                firstfilecreation100 = watch.ElapsedMilliseconds.ToString();

                watch = new System.Diagnostics.Stopwatch();
                watch.Start();
                studentsList100.Sort((x, y) =>

                 x.getFP().CompareTo(y.getFP()));

                watch.Stop();

                datasorting100 = watch.ElapsedMilliseconds.ToString();

                ////////////////////////////////////////////////////////

                watch = new System.Diagnostics.Stopwatch();

                watch.Start();

                for (int i = 0; i < 1000; i++)
                {

                    Random rnd = new Random(DateTime.Now.Millisecond);

                    students temp = new students("Name" + (i + 1), "Surname" + (i + 1), rnd.Next(3, 10), rnd.Next(2, 10), rnd.Next(1, 10), rnd.Next(0, 10), rnd.Next(4, 10), rnd.Next(1, 10));
                    studentsList1000.Add(temp);
                }

                watch.Stop();

                firstfilecreation1000 = watch.ElapsedMilliseconds.ToString();

                watch = new System.Diagnostics.Stopwatch();
                watch.Start();
                studentsList1000.Sort((x, y) =>

                 x.getFP().CompareTo(y.getFP()));

                watch.Stop();

                datasorting1000 = watch.ElapsedMilliseconds.ToString();

                ///////////////////////////////////////////////////////

                watch = new System.Diagnostics.Stopwatch();

                watch.Start();

                for (int i = 0; i < 10000; i++)
                {

                    Random rnd = new Random(DateTime.Now.Millisecond);

                    students temp = new students("Name" + (i + 1), "Surname" + (i + 1), rnd.Next(3, 10), rnd.Next(2, 10), rnd.Next(1, 10), rnd.Next(0, 10), rnd.Next(4, 10), rnd.Next(1, 10));
                    studentsList10000.Add(temp);
                }

                watch.Stop();

                firstfilecreation10000 = watch.ElapsedMilliseconds.ToString();

                watch = new System.Diagnostics.Stopwatch();
                watch.Start();
                studentsList10000.Sort((x, y) =>

                 x.getFP().CompareTo(y.getFP()));

                watch.Stop();

                datasorting10000 = watch.ElapsedMilliseconds.ToString();

                ///////////////////////////////////////////////////////

                watch = new System.Diagnostics.Stopwatch();

                watch.Start();

                for (int i = 0; i < 100000; i++)
                {

                    Random rnd = new Random(DateTime.Now.Millisecond);

                    students temp = new students("Name" + (i + 1), "Surname" + (i + 1), rnd.Next(3, 10), rnd.Next(2, 10), rnd.Next(1, 10), rnd.Next(0, 10), rnd.Next(4, 10), rnd.Next(1, 10));
                    studentsList100000.Add(temp);
                }

                watch.Stop();

                firstfilecreation100000 = watch.ElapsedMilliseconds.ToString();

                watch = new System.Diagnostics.Stopwatch();
                watch.Start();
                studentsList100000.Sort((x, y) =>

                 x.getFP().CompareTo(y.getFP()));

                watch.Stop();

                datasorting100000 = watch.ElapsedMilliseconds.ToString();





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

                    List<String> studentsList100Pass = new List<string>();
                    List<String> studentsList100Fail = new List<String>();

                    File.WriteAllText("studentsList100Pass", String.Empty);
                    File.WriteAllText("studentsList100Fail", String.Empty);

                    var watch = new System.Diagnostics.Stopwatch();

                    watch.Start();

                    for (int i = 0; i < 100; i++)
                    {
                        if (studentsList100[i].getFP() >= 5)
                        {
                            File.AppendAllText("studentsList100Pass", studentsList100[i].getData() + Environment.NewLine);

                            // studentsList100Pass.Add(studentsList100[i].getData());
                        }
                        else
                        {
                            File.AppendAllText("studentsList100Fail", studentsList100[i].getData() + Environment.NewLine);
                            // studentsList100Fail.Add(studentsList100[i].getData());
                        }
                    }
                    watch.Stop();

                    datasplitting100 = watch.ElapsedMilliseconds.ToString();
                    outputofsorted100 = (watch.ElapsedMilliseconds / 100).ToString();

                    watch = new System.Diagnostics.Stopwatch();

                    watch.Start();

                    List<String> studentsList1000Pass = new List<string>();
                    List<String> studentsList1000Fail = new List<String>();

                    File.WriteAllText("studentsList1000Pass", String.Empty);
                    File.WriteAllText("studentsList1000Fail", String.Empty);

                    for (int i = 0; i < 1000; i++)
                    {
                        if (studentsList1000[i].getFP() >= 5)
                        {
                            File.AppendAllText("studentsList1000Pass", studentsList1000[i].getData() + Environment.NewLine);

                            // studentsList100Pass.Add(studentsList100[i].getData());
                        }
                        else
                        {
                            File.AppendAllText("studentsList1000Fail", studentsList1000[i].getData() + Environment.NewLine);
                            // studentsList100Fail.Add(studentsList100[i].getData());
                        }
                    }

                    watch.Stop();

                    datasplitting1000 = watch.ElapsedMilliseconds.ToString();
                    outputofsorted1000 = (watch.ElapsedMilliseconds / 1000).ToString();

                    watch = new System.Diagnostics.Stopwatch();

                    watch.Start();

                    List<String> studentsList10000Pass = new List<string>();
                    List<String> studentsList10000Fail = new List<String>();

                    File.WriteAllText("studentsList10000Pass", String.Empty);
                    File.WriteAllText("studentsList10000Fail", String.Empty);

                    for (int i = 0; i < 10000; i++)
                    {
                        if (studentsList10000[i].getFP() >= 5)
                        {
                            File.AppendAllText("studentsList10000Pass", studentsList10000[i].getData() + Environment.NewLine);

                            // studentsList100Pass.Add(studentsList100[i].getData());
                        }
                        else
                        {
                            File.AppendAllText("studentsList10000Fail", studentsList10000[i].getData() + Environment.NewLine);
                            // studentsList100Fail.Add(studentsList100[i].getData());
                        }
                    }

                    watch.Stop();

                    datasplitting10000 = watch.ElapsedMilliseconds.ToString();
                    outputofsorted10000 = (watch.ElapsedMilliseconds / 10000).ToString();

                    watch = new System.Diagnostics.Stopwatch();

                    watch.Start();



                    List<String> studentsList100000Pass = new List<string>();
                    List<String> studentsList100000Fail = new List<String>();

                    File.WriteAllText("studentsList100000Pass", String.Empty);
                    File.WriteAllText("studentsList100000Fail", String.Empty);

                    for (int i = 0; i < 100000; i++)
                    {

                        if (studentsList100000[i].getFP() >= 5)
                        {
                            File.AppendAllText("studentsList100000Pass", studentsList100000[i].getData() + Environment.NewLine);

                            // studentsList100Pass.Add(studentsList100[i].getData());
                        }
                        else
                        {
                            File.AppendAllText("studentsList100000Fail", studentsList100000[i].getData() + Environment.NewLine);
                            // studentsList100Fail.Add(studentsList100[i].getData());
                        }
                    }

                    watch.Stop();

                    datasplitting100000 = watch.ElapsedMilliseconds.ToString();
                    outputofsorted100000 = (watch.ElapsedMilliseconds / 100000).ToString();


                    File.WriteAllText("ListPerformance", String.Empty);
                    File.AppendAllText("ListPerformance", "" + Environment.NewLine);

                    string ProgramPerformance = "";
                    ProgramPerformance = "For 100 Students :\n";
                    ProgramPerformance = ProgramPerformance + "Data Creation Time : " + firstfilecreation100 + "ms \n";
                    ProgramPerformance = ProgramPerformance + "Data Sorting : " + datasorting100 + "ms \n";
                    ProgramPerformance = ProgramPerformance + "Date Splitting : " + datasplitting100 + "ms \n";
                    ProgramPerformance = ProgramPerformance + "File Creation Time : " + outputofsorted100 + "ms \n\n";

                    ProgramPerformance = ProgramPerformance + "For 1000 Students :\n";
                    ProgramPerformance = ProgramPerformance + "Data Creation Time : " + firstfilecreation1000 + "ms \n";
                    ProgramPerformance = ProgramPerformance + "Data Sorting : " + datasorting1000 + "ms \n";
                    ProgramPerformance = ProgramPerformance + "Date Splitting : " + datasplitting1000 + "ms \n";
                    ProgramPerformance = ProgramPerformance + "File Creation Time : " + outputofsorted1000 + "ms \n\n";

                    ProgramPerformance = ProgramPerformance + "For 10000 Students :\n";
                    ProgramPerformance = ProgramPerformance + "Data Creation Time : " + firstfilecreation10000 + "ms \n";
                    ProgramPerformance = ProgramPerformance + "Data Sorting : " + datasorting10000 + "ms \n";
                    ProgramPerformance = ProgramPerformance + "Date Splitting : " + datasplitting10000 + "\n";
                    ProgramPerformance = ProgramPerformance + "File Creation Time : " + outputofsorted10000 + "\n\n";

                    ProgramPerformance = ProgramPerformance + "For 100000 Students :\n";
                    ProgramPerformance = ProgramPerformance + "Data Creation Time : " + firstfilecreation100000 + "ms \n";
                    ProgramPerformance = ProgramPerformance + "Data Sorting : " + datasorting100000 + "ms \n";
                    ProgramPerformance = ProgramPerformance + "Date Splitting : " + datasplitting100000 + "ms \n";
                    ProgramPerformance = ProgramPerformance + "File Creation Time : " + outputofsorted100000 + "ms \n\n";





                    File.WriteAllText("ListPerformance", ProgramPerformance);
                    //   File.WriteAllText("studentsList100Fail", studentsList100Fail.ToArray().ToString());


                }


                catch
                {
                    Console.Write("There was an error while processing");
                }
            }




        }


        private static void progqlist()
        {
            try
            {

                Console.WriteLine("Processing Please Wait ...");
                var watch = new System.Diagnostics.Stopwatch();

                watch.Start();

                for (int i = 0; i < 100; i++)
                {

                    Random rnd = new Random(DateTime.Now.Millisecond);

                    students temp = new students("Name" + (i + 1), "Surname" + (i + 1), rnd.Next(3, 10), rnd.Next(2, 10), rnd.Next(1, 10), rnd.Next(0, 10), rnd.Next(4, 10), rnd.Next(1, 10));
                    qstudentsList100.Enqueue(temp);
                }

             //   

                watch.Stop();

                firstfilecreation100 = watch.ElapsedMilliseconds.ToString();

                watch = new System.Diagnostics.Stopwatch();
                watch.Start();


                Queue<students> q = new Queue<students>(qstudentsList100.OrderBy(x => x.getFP()));
                qstudentsList100 = q;

                watch.Stop();

               

                datasorting100 = watch.ElapsedMilliseconds.ToString();
             //   Console.WriteLine("OK");
                ////////////////////////////////////////////////////////

                watch = new System.Diagnostics.Stopwatch();

                watch.Start();

                for (int i = 0; i < 1000; i++)
                {

                    Random rnd = new Random(DateTime.Now.Millisecond);

                    students temp = new students("Name" + (i + 1), "Surname" + (i + 1), rnd.Next(3, 10), rnd.Next(2, 10), rnd.Next(1, 10), rnd.Next(0, 10), rnd.Next(4, 10), rnd.Next(1, 10));
                    qstudentsList1000.Enqueue(temp);
                }

                watch.Stop();

                firstfilecreation1000 = watch.ElapsedMilliseconds.ToString();

                watch = new System.Diagnostics.Stopwatch();
                watch.Start();

                q = new Queue<students>(qstudentsList1000.OrderBy(x => x.getFP()));
                qstudentsList1000 = q;

                watch.Stop();

                datasorting1000 = watch.ElapsedMilliseconds.ToString();
             //   Console.WriteLine("OK");
                ///////////////////////////////////////////////////////

                watch = new System.Diagnostics.Stopwatch();

                watch.Start();

                for (int i = 0; i < 10000; i++)
                {

                    Random rnd = new Random(DateTime.Now.Millisecond);

                    students temp = new students("Name" + (i + 1), "Surname" + (i + 1), rnd.Next(3, 10), rnd.Next(2, 10), rnd.Next(1, 10), rnd.Next(0, 10), rnd.Next(4, 10), rnd.Next(1, 10));
                    qstudentsList10000.Enqueue(temp);
                }

                watch.Stop();

                firstfilecreation10000 = watch.ElapsedMilliseconds.ToString();

                watch = new System.Diagnostics.Stopwatch();
                watch.Start();
                q = new Queue<students>(qstudentsList10000.OrderBy(x => x.getFP()));
                qstudentsList10000 = q;

                watch.Stop();

                datasorting10000 = watch.ElapsedMilliseconds.ToString();

             //   Console.WriteLine("OK");
                ///////////////////////////////////////////////////////

                watch = new System.Diagnostics.Stopwatch();

                watch.Start();

                for (int i = 0; i < 100000; i++)
                {

                    Random rnd = new Random(DateTime.Now.Millisecond);

                    students temp = new students("Name" + (i + 1), "Surname" + (i + 1), rnd.Next(3, 10), rnd.Next(2, 10), rnd.Next(1, 10), rnd.Next(0, 10), rnd.Next(4, 10), rnd.Next(1, 10));
                    qstudentsList100000.Enqueue(temp);
                }

                watch.Stop();

                firstfilecreation100000 = watch.ElapsedMilliseconds.ToString();

                watch = new System.Diagnostics.Stopwatch();
                watch.Start();
                q = new Queue<students>(qstudentsList100000.OrderBy(x => x.getFP()));
                qstudentsList100000 = q;

                watch.Stop();

                datasorting100000 = watch.ElapsedMilliseconds.ToString();

              //  Console.WriteLine("OK");



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

                    List<String> studentsList100Pass = new List<string>();
                    List<String> studentsList100Fail = new List<String>();

                    File.WriteAllText("qstudentsList100Pass", String.Empty);
                    File.WriteAllText("qstudentsList100Fail", String.Empty);

                    var watch = new System.Diagnostics.Stopwatch();

                    watch.Start();

                    for (int i = 0; i < 100; i++)
                    {
                        if (qstudentsList100.ElementAt(i).getFP() >= 5)
                        {
                            File.AppendAllText("qstudentsList100Pass", qstudentsList100.ElementAt(i).getData() + Environment.NewLine);

                            // studentsList100Pass.Add(studentsList100[i].getData());
                        }
                        else
                        {
                            File.AppendAllText("qstudentsList100Fail", qstudentsList100.ElementAt(i).getData() + Environment.NewLine);
                            // studentsList100Fail.Add(studentsList100[i].getData());
                        }
                    }
                    watch.Stop();

                    datasplitting100 = watch.ElapsedMilliseconds.ToString();
                    outputofsorted100 = (watch.ElapsedMilliseconds / 100).ToString();
                //    Console.WriteLine("OK 100");
                    watch = new System.Diagnostics.Stopwatch();

                    watch.Start();

                    List<String> studentsList1000Pass = new List<string>();
                    List<String> studentsList1000Fail = new List<String>();

                    File.WriteAllText("qstudentsList1000Pass", String.Empty);
                    File.WriteAllText("qstudentsList1000Fail", String.Empty);

                    for (int i = 0; i < 1000; i++)
                    {
                        if (qstudentsList1000.ElementAt(i).getFP() >= 5)
                        {
                            File.AppendAllText("qstudentsList1000Pass", qstudentsList1000.ElementAt(i).getData() + Environment.NewLine);

                            // studentsList100Pass.Add(studentsList100[i].getData());
                        }
                        else
                        {
                            File.AppendAllText("qstudentsList1000Fail", qstudentsList1000.ElementAt(i).getData() + Environment.NewLine);
                            // studentsList100Fail.Add(studentsList100[i].getData());
                        }
                    }

                    watch.Stop();

                    datasplitting1000 = watch.ElapsedMilliseconds.ToString();
                    outputofsorted1000 = (watch.ElapsedMilliseconds / 1000).ToString();
               //     Console.WriteLine("OK 1000");
                    watch = new System.Diagnostics.Stopwatch();

                    watch.Start();

                    List<String> studentsList10000Pass = new List<string>();
                    List<String> studentsList10000Fail = new List<String>();

                    File.WriteAllText("qstudentsList10000Pass", String.Empty);
                    File.WriteAllText("qstudentsList10000Fail", String.Empty);

                    for (int i = 0; i < 10000; i++)
                    {
                        if (qstudentsList10000.ElementAt(i).getFP() >= 5)
                        {
                            File.AppendAllText("qstudentsList10000Pass", qstudentsList10000.ElementAt(i).getData() + Environment.NewLine);

                            // studentsList100Pass.Add(studentsList100[i].getData());
                        }
                        else
                        {
                            File.AppendAllText("qstudentsList10000Fail", qstudentsList10000.ElementAt(i).getData() + Environment.NewLine);
                            // studentsList100Fail.Add(studentsList100[i].getData());
                        }
                    }

                    watch.Stop();

                    datasplitting10000 = watch.ElapsedMilliseconds.ToString();
                    outputofsorted10000 = (watch.ElapsedMilliseconds / 10000).ToString();
                //    Console.WriteLine("OK 10000");
                    watch = new System.Diagnostics.Stopwatch();

                    watch.Start();



                    List<String> studentsList100000Pass = new List<string>();
                    List<String> studentsList100000Fail = new List<String>();

                    File.WriteAllText("qstudentsList100000Pass", String.Empty);
                    File.WriteAllText("qstudentsList100000Fail", String.Empty);

                    for (int i = 0; i < 100000; i++)
                    {

                        if (qstudentsList100000.ElementAt(i).getFP() >= 5)
                        {
                            File.AppendAllText("qstudentsList100000Pass", qstudentsList100000.ElementAt(i).getData() + Environment.NewLine);

                            // studentsList100Pass.Add(studentsList100[i].getData());
                        }
                        else
                        {
                            File.AppendAllText("qstudentsList100000Fail", qstudentsList100000.ElementAt(i).getData() + Environment.NewLine);
                            // studentsList100Fail.Add(studentsList100[i].getData());
                        }
                    }

                    watch.Stop();
                //    Console.WriteLine("OK 100000");
                    datasplitting100000 = watch.ElapsedMilliseconds.ToString();
                    outputofsorted100000 = (watch.ElapsedMilliseconds / 100000).ToString();


                    File.WriteAllText("qPerformance", String.Empty);
                    File.AppendAllText("qPerformance", "" + Environment.NewLine);

                    string ProgramPerformance = "";
                    ProgramPerformance = "For 100 Students :\n";
                    ProgramPerformance = ProgramPerformance + "Data Creation Time : " + firstfilecreation100 + "ms \n";
                    ProgramPerformance = ProgramPerformance + "Data Sorting : " + datasorting100 + "ms \n";
                    ProgramPerformance = ProgramPerformance + "Date Splitting : " + datasplitting100 + "ms \n";
                    ProgramPerformance = ProgramPerformance + "File Creation Time : " + outputofsorted100 + "ms \n\n";

                    ProgramPerformance = ProgramPerformance + "For 1000 Students :\n";
                    ProgramPerformance = ProgramPerformance + "Data Creation Time : " + firstfilecreation1000 + "ms \n";
                    ProgramPerformance = ProgramPerformance + "Data Sorting : " + datasorting1000 + "ms \n";
                    ProgramPerformance = ProgramPerformance + "Date Splitting : " + datasplitting1000 + "ms \n";
                    ProgramPerformance = ProgramPerformance + "File Creation Time : " + outputofsorted1000 + "ms \n\n";

                    ProgramPerformance = ProgramPerformance + "For 10000 Students :\n";
                    ProgramPerformance = ProgramPerformance + "Data Creation Time : " + firstfilecreation10000 + "ms \n";
                    ProgramPerformance = ProgramPerformance + "Data Sorting : " + datasorting10000 + "ms \n";
                    ProgramPerformance = ProgramPerformance + "Date Splitting : " + datasplitting10000 + "\n";
                    ProgramPerformance = ProgramPerformance + "File Creation Time : " + outputofsorted10000 + "\n\n";

                    ProgramPerformance = ProgramPerformance + "For 100000 Students :\n";
                    ProgramPerformance = ProgramPerformance + "Data Creation Time : " + firstfilecreation100000 + "ms \n";
                    ProgramPerformance = ProgramPerformance + "Data Sorting : " + datasorting100000 + "ms \n";
                    ProgramPerformance = ProgramPerformance + "Date Splitting : " + datasplitting100000 + "ms \n";
                    ProgramPerformance = ProgramPerformance + "File Creation Time : " + outputofsorted100000 + "ms \n\n";





                    File.WriteAllText("qPerformance", ProgramPerformance);
                    //   File.WriteAllText("studentsList100Fail", studentsList100Fail.ToArray().ToString());
                    Environment.Exit(0);

                }


                catch
                {
                    Console.Write("There was an error while processing");
                }
            }

        }

        private static void progLLlist()
        {
            try
            {

                Console.WriteLine("Processing Please Wait ...");
                var watch = new System.Diagnostics.Stopwatch();

                watch.Start();

                for (int i = 0; i < 100; i++)
                {

                    Random rnd = new Random(DateTime.Now.Millisecond);

                    students temp = new students("Name" + (i + 1), "Surname" + (i + 1), rnd.Next(3, 10), rnd.Next(2, 10), rnd.Next(1, 10), rnd.Next(0, 10), rnd.Next(4, 10), rnd.Next(1, 10));
                    LLstudentsList100.AddLast(temp);
                 //   Console.Write(LLstudentsList100.ElementAt(i).getData());


                }

                //   

                watch.Stop();

                firstfilecreation100 = watch.ElapsedMilliseconds.ToString();

                watch = new System.Diagnostics.Stopwatch();
                watch.Start();


                LinkedList<students> q = new LinkedList<students>(qstudentsList100.OrderBy(x => x.getFP()));
                LLstudentsList100 = q;

               
              //  Console.Write(LLstudentsList100.ElementAt(1).getData());

                watch.Stop();



                datasorting100 = watch.ElapsedMilliseconds.ToString();
             //   Console.WriteLine("OK");
                ////////////////////////////////////////////////////////

                watch = new System.Diagnostics.Stopwatch();

                watch.Start();

                for (int i = 0; i < 1000; i++)
                {

                    Random rnd = new Random(DateTime.Now.Millisecond);

                    students temp = new students("Name" + (i + 1), "Surname" + (i + 1), rnd.Next(3, 10), rnd.Next(2, 10), rnd.Next(1, 10), rnd.Next(0, 10), rnd.Next(4, 10), rnd.Next(1, 10));
                    LLstudentsList1000.AddLast(temp);
                }

                watch.Stop();

                firstfilecreation1000 = watch.ElapsedMilliseconds.ToString();

                watch = new System.Diagnostics.Stopwatch();
                watch.Start();

                q = new LinkedList<students>(LLstudentsList1000.OrderBy(x => x.getFP()));
                LLstudentsList1000 = q;

                watch.Stop();

                datasorting1000 = watch.ElapsedMilliseconds.ToString();
              //  Console.WriteLine("OK");
                ///////////////////////////////////////////////////////

                watch = new System.Diagnostics.Stopwatch();

                watch.Start();

                for (int i = 0; i < 10000; i++)
                {

                    Random rnd = new Random(DateTime.Now.Millisecond);

                    students temp = new students("Name" + (i + 1), "Surname" + (i + 1), rnd.Next(3, 10), rnd.Next(2, 10), rnd.Next(1, 10), rnd.Next(0, 10), rnd.Next(4, 10), rnd.Next(1, 10));
                    LLstudentsList10000.AddLast(temp);
                }

                watch.Stop();

                firstfilecreation10000 = watch.ElapsedMilliseconds.ToString();

                watch = new System.Diagnostics.Stopwatch();
                watch.Start();
                q = new LinkedList<students>(LLstudentsList10000.OrderBy(x => x.getFP()));
                LLstudentsList10000 = q;

                watch.Stop();

                datasorting10000 = watch.ElapsedMilliseconds.ToString();

              //  Console.WriteLine("OK");
                ///////////////////////////////////////////////////////

                watch = new System.Diagnostics.Stopwatch();

                watch.Start();

                for (int i = 0; i < 100000; i++)
                {

                    Random rnd = new Random(DateTime.Now.Millisecond);

                    students temp = new students("Name" + (i + 1), "Surname" + (i + 1), rnd.Next(3, 10), rnd.Next(2, 10), rnd.Next(1, 10), rnd.Next(0, 10), rnd.Next(4, 10), rnd.Next(1, 10));
                    LLstudentsList100000.AddLast(temp);
                }

                watch.Stop();

                firstfilecreation100000 = watch.ElapsedMilliseconds.ToString();

                watch = new System.Diagnostics.Stopwatch();
                watch.Start();
                q = new LinkedList<students>(LLstudentsList100000.OrderBy(x => x.getFP()));
                LLstudentsList100000 = q;

                watch.Stop();

                datasorting100000 = watch.ElapsedMilliseconds.ToString();

             //   Console.WriteLine("OK LL");



            }
            catch (Exception ex)
            {
                Console.WriteLine("There was an error opening file" + ex);
                // handle exception
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
                Environment.Exit(0);
               
            }
            finally
            {


                try
                { //input of two int numbers num1 and num2 and devision result output


                    List<String> studentsList100Pass = new List<string>();
                    List<String> studentsList100Fail = new List<String>();

                    File.WriteAllText("LLstudentsList100Pass", String.Empty);
                    File.WriteAllText("LLstudentsList100Fail", String.Empty);

                    var watch = new System.Diagnostics.Stopwatch();

                    watch.Start();


                    foreach (students s in LLstudentsList100)
                    {
                        if (s.getFP() >= 5)
                        {
                            File.AppendAllText("LLstudentsList100Pass", s.getData() + Environment.NewLine);

                            // studentsList100Pass.Add(studentsList100[i].getData());
                        }
                        else
                        {
                            File.AppendAllText("LLstudentsList100Fail", s.getData() + Environment.NewLine);
                            // studentsList100Fail.Add(studentsList100[i].getData());
                        }
                    }

                   
                    watch.Stop();

                    datasplitting100 = watch.ElapsedMilliseconds.ToString();
                    outputofsorted100 = (watch.ElapsedMilliseconds / 100).ToString();
                  //  Console.WriteLine("OK 100");


                    watch = new System.Diagnostics.Stopwatch();

                    watch.Start();

                    List<String> studentsList1000Pass = new List<string>();
                    List<String> studentsList1000Fail = new List<String>();

                    File.WriteAllText("LLstudentsList1000Pass", String.Empty);
                    File.WriteAllText("LLstudentsList1000Fail", String.Empty);

                    foreach (students s in LLstudentsList1000)
                    {
                        if (s.getFP() >= 5)
                        {
                            File.AppendAllText("LLstudentsList1000Pass", s.getData() + Environment.NewLine);

                            // studentsList100Pass.Add(studentsList100[i].getData());
                        }
                        else
                        {
                            File.AppendAllText("LLstudentsList1000Fail", s.getData() + Environment.NewLine);
                            // studentsList100Fail.Add(studentsList100[i].getData());
                        }
                    }

                    watch.Stop();

                    datasplitting1000 = watch.ElapsedMilliseconds.ToString();
                    outputofsorted1000 = (watch.ElapsedMilliseconds / 1000).ToString();
                  //  Console.WriteLine("OK 1000");
                    watch = new System.Diagnostics.Stopwatch();

                    watch.Start();

                    List<String> studentsList10000Pass = new List<string>();
                    List<String> studentsList10000Fail = new List<String>();

                    File.WriteAllText("LLstudentsList10000Pass", String.Empty);
                    File.WriteAllText("LLstudentsList10000Fail", String.Empty);

                    foreach (students s in LLstudentsList10000)
                    {
                        if (s.getFP() >= 5)
                        {
                            File.AppendAllText("LLstudentsList10000Pass", s.getData() + Environment.NewLine);

                            // studentsList100Pass.Add(studentsList100[i].getData());
                        }
                        else
                        {
                            File.AppendAllText("LLstudentsList10000Fail", s.getData() + Environment.NewLine);
                            // studentsList100Fail.Add(studentsList100[i].getData());
                        }
                    }

                    watch.Stop();

                    datasplitting10000 = watch.ElapsedMilliseconds.ToString();
                    outputofsorted10000 = (watch.ElapsedMilliseconds / 10000).ToString();
                  //  Console.WriteLine("OK 10000");
                    watch = new System.Diagnostics.Stopwatch();

                    watch.Start();



                    List<String> studentsList100000Pass = new List<string>();
                    List<String> studentsList100000Fail = new List<String>();

                    File.WriteAllText("LLstudentsList100000Pass", String.Empty);
                    File.WriteAllText("LLstudentsList100000Fail", String.Empty);

                    for (int i = 0; i < 100000; i++)
                    {

                        foreach (students s in LLstudentsList100000)
                        {
                            if (s.getFP() >= 5)
                            {
                                File.AppendAllText("LLstudentsList100000Pass", s.getData() + Environment.NewLine);

                                // studentsList100Pass.Add(studentsList100[i].getData());
                            }
                            else
                            {
                                File.AppendAllText("LLstudentsList100000Fail", s.getData() + Environment.NewLine);
                                // studentsList100Fail.Add(studentsList100[i].getData());
                            }
                        }
                    }

                    watch.Stop();
                   // Console.WriteLine("OK 100000");
                    datasplitting100000 = watch.ElapsedMilliseconds.ToString();
                    outputofsorted100000 = (watch.ElapsedMilliseconds / 100000).ToString();


                    File.WriteAllText("LLPerformance", String.Empty);
                    File.AppendAllText("LLPerformance", "" + Environment.NewLine);

                    string ProgramPerformance = "";
                    ProgramPerformance = "For 100 Students :\n";
                    ProgramPerformance = ProgramPerformance + "Data Creation Time : " + firstfilecreation100 + "ms \n";
                    ProgramPerformance = ProgramPerformance + "Data Sorting : " + datasorting100 + "ms \n";
                    ProgramPerformance = ProgramPerformance + "Date Splitting : " + datasplitting100 + "ms \n";
                    ProgramPerformance = ProgramPerformance + "File Creation Time : " + outputofsorted100 + "ms \n\n";

                    ProgramPerformance = ProgramPerformance + "For 1000 Students :\n";
                    ProgramPerformance = ProgramPerformance + "Data Creation Time : " + firstfilecreation1000 + "ms \n";
                    ProgramPerformance = ProgramPerformance + "Data Sorting : " + datasorting1000 + "ms \n";
                    ProgramPerformance = ProgramPerformance + "Date Splitting : " + datasplitting1000 + "ms \n";
                    ProgramPerformance = ProgramPerformance + "File Creation Time : " + outputofsorted1000 + "ms \n\n";

                    ProgramPerformance = ProgramPerformance + "For 10000 Students :\n";
                    ProgramPerformance = ProgramPerformance + "Data Creation Time : " + firstfilecreation10000 + "ms \n";
                    ProgramPerformance = ProgramPerformance + "Data Sorting : " + datasorting10000 + "ms \n";
                    ProgramPerformance = ProgramPerformance + "Date Splitting : " + datasplitting10000 + "\n";
                    ProgramPerformance = ProgramPerformance + "File Creation Time : " + outputofsorted10000 + "\n\n";

                    ProgramPerformance = ProgramPerformance + "For 100000 Students :\n";
                    ProgramPerformance = ProgramPerformance + "Data Creation Time : " + firstfilecreation100000 + "ms \n";
                    ProgramPerformance = ProgramPerformance + "Data Sorting : " + datasorting100000 + "ms \n";
                    ProgramPerformance = ProgramPerformance + "Date Splitting : " + datasplitting100000 + "ms \n";
                    ProgramPerformance = ProgramPerformance + "File Creation Time : " + outputofsorted100000 + "ms \n\n";





                    File.WriteAllText("LLPerformance", ProgramPerformance);
                    //   File.WriteAllText("studentsList100Fail", studentsList100Fail.ToArray().ToString());
                 //   Environment.Exit(0);

                }


                catch
                {
                    Console.Write("There was an error while processing");
                }
            }

        }


    }
}
