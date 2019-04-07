using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_8
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<IStudent> students = new List<IStudent>();
            students.Add(new Student_of_univers());
            students.Add(new Student_of_college());
            foreach (IStudent s in students)
            {
                s.GetPass_the_exam();
                s.GetPayment();
            }
            Console.ReadLine();

        }
    }
}
