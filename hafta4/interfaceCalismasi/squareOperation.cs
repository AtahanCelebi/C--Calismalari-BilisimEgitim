using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceCalismasi
{
    internal class squareOperation: IOperation
    {
        public double Alan(Shape shape)
        {
            return (shape.x * shape.x) ;
        }

        public double Cevre(Shape shape)
        {
            return shape.x * 4;
        }
    }
}
