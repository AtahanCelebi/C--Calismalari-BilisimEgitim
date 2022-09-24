using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceCalismasi
{
    internal class rectangleOperation: IOperation
    {
        public double Alan(Shape shape)
        {
            return shape.x * shape.y;
        }

        public double Cevre(Shape shape)
        {
            return 2 * (shape.x + shape.y);
        }
    }
}
