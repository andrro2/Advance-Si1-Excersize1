using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersize1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime(2000,05,24);
            Person person = new Person("Jack",date,Gender.MALE);
            Console.WriteLine(person);
            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
        }
    }
}
