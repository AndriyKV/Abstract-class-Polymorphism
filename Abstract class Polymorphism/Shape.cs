using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class_Polymorphism
{
    class Shape
    {
        //protected int i;

        //public float Width { get; set; }
        //public float Height { get; set; }

        //public Shape(float width, float height)
        //{
        //    Width = width;
        //    Height = height;
        //}

        //private void Output()
        //{
        //    Console.WriteLine("Private Implemented Method");
        //}

        public abstract void Draw(float widht, float height);
        //public virtual void Draw(float widht, float height)//4
        //{
        //}
    }
}
