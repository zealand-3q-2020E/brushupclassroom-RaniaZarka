using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Student
    {
        string name;
        int birthMonth;
        int birthDay;

        public Student( string Name, int BirthMonth, int BirthDay)
        {
            name = Name;
            birthDay = BirthDay;
            birthMonth = BirthMonth;
        }

        public string Name { get; set; }
        public int BirthMonth { get; set; }
        public int BirthDay { get; set; }


       
    }
}
