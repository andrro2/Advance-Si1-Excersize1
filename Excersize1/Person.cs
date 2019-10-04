using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersize1
{
    class Person
    {
        private string name;
        private DateTime birtDate;
        private Gender gender;

        public Person(string name, DateTime birtDate, Gender gender)
        {
            this.name = name;
            this.birtDate = birtDate;
            this.gender = gender;
        }

       
        public override string ToString()
        {
            return "Name: " + name + ", birt date: " + birtDate + ", Gender: "+ gender;
        }
    }
}
