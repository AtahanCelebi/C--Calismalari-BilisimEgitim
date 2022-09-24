using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceCalismasi
{
    internal class triangleOperation: IOperation
    {
        public double Alan(Shape shape)
        {
            return (shape.x * shape.y)/2;
        }

        public double Cevre(Shape shape)
        {
            throw new NotImplementedException(); //geliştirilmediği için pass yaptık!
        }

        public double Cevre(Triangle shape)
        {
            return shape.x + shape.y + shape.z;
        }
    }
}
