using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class_Polymorphism
{
    class Ellipse : Circle
    {
        public override void Draw(float widht, float height)
        {
            Console.WriteLine("Like an egg");
        }
    }
}
