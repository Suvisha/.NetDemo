using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    public abstract class shape
    {
        private float _area;
        private float _perimeter;
        public float area
        {
            get { return _area; }
            set { _area = value; }
        }
        public float perimeter
        {
            get { return _perimeter; }
            set { _perimeter = value; }
        }
        public abstract void CalculateArea();
        public abstract void CalculatePerimeter();

    }
}
