using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_8
{
    interface IStudent
    {
        void GetName();
        void GetPass_the_Practice();
        void GetPass_the_exam();
        void GetPayment();

        void SetName(string value);
        void SetPass_the_Practice(int value);
        void SetPass_the_exam(int value);
        void SetPayment(int value); 
        
    }
}
