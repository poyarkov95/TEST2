using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryNEW
{
    class Square : Shape
    {
        double x, y, side;
        string name;
        public void Load(string[] type)
        {
            this.x = double.Parse(type[1]);
            this.y = double.Parse(type[2]);
            this.side = double.Parse(type[3]);
            this.name = type[4];
        }
    }
}
