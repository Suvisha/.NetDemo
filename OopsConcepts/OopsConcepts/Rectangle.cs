using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    class Rectangle:shape
    {
        private float _height;
        private float _width;
        public float height
        {
            get { return _height; }
            set { _height = value; }
        }
        public float width
        {
            get { return _width; }
            set { _width = value; }
        }
        public Rectangle(float height,float width)
        {
            _height = height;
            _width = width;
            CalculateArea();
            CalculatePerimeter();
        }
        public override void CalculateArea()
        {
            this.area = _height * _width;
            Console.WriteLine("Area of Rectangle:"+this.area);
        }
        public override void CalculatePerimeter()
        {
            this.perimeter = (_height * 2) + (_width * 2);
            Console.WriteLine("Perimeter of Rectangle:"+this.perimeter);
        }
    }
}
