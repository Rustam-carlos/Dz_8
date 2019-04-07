using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_8
{
    class Student_of_college : IStudent
    {
        public string Name;
        public int count_Practice;
        public int count_exam;
        public int Payment;

        //public Student_of_college()
        //{
        //    Name = "SOC";
        //    count_Practice = 1;
        //    count_exam = 1;
        //    Payment = 100;
        //}

        public void GetName()
        {
            Console.WriteLine("class Student_of_college, метод GetName");
        }
        public void GetPass_the_Practice()
        {
            Console.WriteLine("class Student_of_college, метод GetPass_the_Practice");
        }
        public void GetPass_the_exam()
        {
            Console.WriteLine("class Student_of_college, метод GetPass_the_exam");
        }
        public void GetPayment()
        {
            Console.WriteLine("class Student_of_college, метод GetPayment");
        }

        public void SetName(string value)
        {
            Name = value;
            Console.WriteLine("class Student_of_college, метод SetName");
        }
        public void SetPass_the_Practice(int value)
        {
            if (value < 1)
                count_Practice = 1;
            else count_Practice = value;
            Console.WriteLine("class Student_of_college, метод SetPass_the_Practice");
        }
        public void SetPass_the_exam(int value)
        {
            if (value < 1)
                count_exam = 1;
            else count_exam = value;
            Console.WriteLine("class Student_of_college, метод SetPass_the_exam");
        }
        public void SetPayment(int value)
        {
            Payment = value;
            Console.WriteLine("class Student_of_college, метод SetPayment");
        }
    }
}
