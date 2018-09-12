using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class_Polymorphism
{
    class Function
    {
        public void Ui()
        {
            Console.WriteLine("Empty method\n");
        }
        public void Ui(string Name)
        {
            Console.WriteLine("First Name: {0}", Name);
        }
        public void Ui(string Name, string Surname)
        {
            Console.WriteLine("First Name :{0}\nLast Name: {1}", Name, Surname);
        }
    }
}
