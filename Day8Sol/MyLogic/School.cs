using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLogic
{


    public interface ISchool
    {
    }
    public class School
    {
        int schoolId;
        string schoolName="DPS";

        public void ShowSchoolName()
        {
            Console.WriteLine("school name: " +schoolName);
        }

        public void RegNewSchool(string name)
        {
            schoolName = name;
        }


    }

    public class MyMath
    {
    public void Sum(int v1,int v2)
        {
            Console.WriteLine("sum:{0}",(v1+v2));
        }

        public void Sub(int v1, int v2)
        {
            Console.WriteLine("sum:{0}", (v1 - v2));
        }
        public void Div(int v1, int v2)
        {
            Console.WriteLine("sum:{0}", (v1 / v2));
        }
        public void Mul(int v1, int v2)
        {
            Console.WriteLine("sum:{0}", (v1 * v2));
        }
    }
}
