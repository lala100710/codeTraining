using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ap_objectOriented
{
    internal class Cube
    {
        private double _length,_width,_height;
        public  Cube(double length,double width,double height)
        {
            _height=height;
            _width=width;
            _length=length;
        }
        public double Volume()
        {
            
            return _height*_length*_width;
        }
        public double Area()
        {
            return 2*(_length*_height+_width+_length*_width*_height);
        }
        

    }
}
