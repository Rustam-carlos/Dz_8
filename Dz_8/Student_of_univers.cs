using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_8
{
    class Student_of_univers : IStudent
    {
        public string s_u_Name;
        public int cnt_Practice;
        public int cnt_exam;
        public int Payment;

        //public Student_of_univers()
        //{
        //    s_u_Name = "SOU";
        //    cnt_Practice = 1;
        //    cnt_exam = 1;
        //    Payment = 100;
        //}

        public void GetName()
        {
            Console.WriteLine("class Student_of_univers, метод GetName");
        }
        public void GetPass_the_Practice()
        {
            Console.WriteLine("class Student_of_univers, метод GetPass_the_Practice");
        }
        public void GetPass_the_exam()
        {
            Console.WriteLine("class Student_of_univers, метод GetPass_the_exam");
        }
        public void GetPayment()
        {
            Console.WriteLine("class Student_of_univers, метод GetPayment");
        }

        public void SetName(string value)
        {
            s_u_Name = value;
            Console.WriteLine("class Student_of_univers, метод SetName");
        }
        public void SetPass_the_Practice(int value)
        {
            if (value < 1)
               cnt_Practice = 1;            
            else cnt_Practice = value;
            Console.WriteLine("class Student_of_univers, метод SetPass_the_Practice");
        }
        public void SetPass_the_exam(int value)
        {
            if (value < 1)
                cnt_exam = 1;
            else cnt_exam = value;
            Console.WriteLine("class Student_of_univers, метод SetPass_the_exam");
        }
        public void SetPayment(int value)
        {
            Payment = value;
            Console.WriteLine("class Student_of_univers, метод SetPayment");
        }
    }
}
