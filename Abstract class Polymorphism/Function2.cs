using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class_Polymorphism
{
    //якщо в кожному меоді буде однакова реалізація це буде прикладом параметричного поліморфізму
    class Function2
    {
        public void Ui()
        {
            Console.WriteLine("Empty method\n");
        }
        public void Ui(string Name)
        {
            Console.WriteLine("Empty method\n");
        }
        public void Ui(string Name, string Surname)
        {
            Console.WriteLine("Empty method\n");
        }
    }
}
