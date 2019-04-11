using System;
namespace v0dot3
{
    public class students_for_task3
    {

        String fullName;
        String surName;
        int HW1,HW2,HW3,HW4,HW5,Exam;
        
        public students(String fullName,String surName,int HW1, int HW2, int HW3, int HW4, int HW5, int Exam)
        {
            this.fullName = fullName;
            this.surName = surName;
            this.HW1 = HW1;
            this.HW2 = HW2;
            this.HW3 = HW3;
            this.HW4 = HW4; 
            this.HW5 = HW5;
            this.Exam = Exam;
        }

        public String getName()
        {
            return this.fullName;
        }

        public String getsurName()
        {
            return this.surName;
        }

        public int getH1()
        {
            return this.HW1;
        }
        public int getH2()
        {
            return this.HW2;
        }
        public int getH3()
        {
            return this.HW3;
        }
        public int getH4()
        {
            return this.HW4;
        }
        public int getH5()
        {
            return this.HW5;
        }
        public int getExam()
        {
            return this.Exam;
        }
    }
}
